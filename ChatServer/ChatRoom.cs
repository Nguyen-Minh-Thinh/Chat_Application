﻿using Mikejzx.ChatShared;

namespace Mikejzx.ChatServer
{
    public class ChatRoom
    {
        // Owner of the room.  Null if the server owns it.
        public ChatServerClient? owner;

        // Name of the room
        public string name;

        // Room topic.
        public string topic;

        private ServerForm _serverForm;  // Tham chiếu tới ServerForm

        // Users in the room.
        public HashSet<ChatServerClient> clients = new HashSet<ChatServerClient>();

        // Whether the room is encrypted.
        //
        // Note that the server never actually sees the private key; the key
        // is generated by the clients through a password that they should each
        // know.  This is a form of end-to-end encryption.
        public bool isEncrypted;

        // True if the room is a 'global room' managed by the server.
        private bool m_IsGlobal;

        public bool IsGlobal { get => m_IsGlobal; }

        // Room message history
        private List<ChatMessage> m_Messages;

        public List<ChatMessage> Messages { get => m_Messages; }

        public ChatRoom(ServerForm serverForm, ChatServerClient? owner, string name, string topic, bool isEncrypted = false, bool isGlobal = false)
        {
            _serverForm = serverForm;  // Gán ServerForm vào _serverForm
            this.owner = owner;
            this.name = name;
            this.topic = topic;
            this.isEncrypted = isEncrypted;
            this.m_IsGlobal = isGlobal;
            this.m_Messages = new List<ChatMessage>();

            clients.Clear();

            if (owner is not null)
            {
                // Gọi phương thức AppendLog khi phòng được tạo
                _serverForm.AppendLog($"Room '{name}' created by {owner.Nickname}");
            }
        }
        // Phương thức dùng để thêm thông báo vào richTextBox
        private void AppendMessageToRichTextBox(string message)
        {
            _serverForm.AppendLog(message);
        }

        // Add a client to the room
        public void AddClient(ChatServerClient client)
        {
            if (clients.Contains(client))
            {
                AppendMessageToRichTextBox($"Client '{client}' already exists in room '{name}'");
                return;
            }

            // Add join message to the message history.
            ChatMessage msg = new ChatMessage(ChatMessageType.UserJoinRoom, client.ToString());
            AddMessage(msg);

            clients.Add(client);

            // And add room to client's internal list.
            client.Rooms.Add(this);

            // Send join message to all other clients in the room.
            using (Packet packet = new Packet(PacketType.ServerClientRoomJoin))
            {
                packet.Write(this.name);
                packet.Write(client.ToString());

                foreach (ChatServerClient client2 in this.clients)
                {
                    lock (client2.sendSync)
                    {
                        packet.WriteToStream(client2.Writer);
                        client2.Writer.Flush();
                    }
                }
            }

            // Send the current list of clients to the newly-joining
            // client.  We include the newly joining client to indicate
            // that they are a part of the room now.
            using (Packet packet = new Packet(PacketType.ServerClientRoomMembers))
            {
                packet.Write(this.name);
                packet.Write(this.clients.Count);

                foreach (ChatServerClient client2 in this.clients)
                {
                    packet.Write(client2.ToString());
                }

                lock (client.sendSync)
                {
                    packet.WriteToStream(client.Writer);
                    client.Writer.Flush();
                }
            }

            // Send the current message history to the newly-joining
            // client.
            using (Packet packet = new Packet(PacketType.ServerClientRoomMessages))
            {
                packet.Write(this.name);
                packet.Write(this.Messages.Count);

                foreach (ChatMessage message in this.Messages)
                {
                    packet.Write((int)message.type);
                    packet.Write(message.author);

                    if (message.message is not null)
                    {
                        packet.Write(message.message);

                        if (this.isEncrypted && message.type == ChatMessageType.UserMessage)
                        {
                            // Include initialisation vector for encrypted
                            // messages.
                            if (message.ivString is not null)
                                packet.Write(message.ivString);
                            else
                                packet.Write(string.Empty);
                        }
                    }
                    else
                    {
                        packet.Write(string.Empty);
                    }
                }

                lock (client.sendSync)
                {
                    packet.WriteToStream(client.Writer);
                    client.Writer.Flush();
                }
            }
        }

        // Add a message to the room.
        public void AddMessage(ChatMessage message)
        {
            Messages.Add(message);

            // Send the message back to everyone in the room
            using (Packet packet = new Packet(PacketType.ServerRoomMessageReceived))
            {
                // Write the room name
                packet.Write(this.name);

                // Write message data.
                packet.Write((int)message.type);
                packet.Write(message.author);

                // Send message string
                if (message.message is not null)
                {
                    packet.Write(message.message);

                    if (this.isEncrypted && message.type == ChatMessageType.UserMessage)
                    {
                        // Include initialisation vector for encrypted messages.
                        if (message.ivString is not null)
                            packet.Write(message.ivString);
                        else
                            packet.Write(string.Empty);
                    }
                }
                else
                {
                    packet.Write(string.Empty);
                }

                // Send the message to all clients who are in the room.
                foreach (ChatServerClient client in this.clients)
                {
                    lock (client.sendSync)
                    {
                        packet.WriteToStream(client.Writer);
                        client.Writer.Flush();
                    }
                }
            }
        }
    }
}