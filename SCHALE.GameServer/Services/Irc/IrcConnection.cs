﻿using SCHALE.Common.Database;
using System.Net.Sockets;
using System.Text.Json;

namespace SCHALE.GameServer.Services.Irc
{
    public class IrcConnection
    {
        public required TcpClient TcpClient { get; set; }

        public required SCHALEContext Context { get; set; }

        public required StreamWriter StreamWriter { get; set; }

        public required ExcelTableService ExcelTableService { get; set; }

        public long AccountServerId { get; set; }

        public string CurrentChannel {  get; set; }

        public AccountDB Account { get => Context.Accounts.FirstOrDefault(x => x.ServerId == AccountServerId); }

        public void SendChatMessage(string text)
        {
            SendChatMessage(text, "Arona", 19009113, 0, IrcMessageType.Chat);
        }

        public void SendEmote(long stickerId)
        {
            SendChatMessage("", "Arona", 19009113, stickerId, IrcMessageType.Sticker);
        }

        public void SendChatMessage(string text, string nickname, long pfpCharacterId, long stickerId, IrcMessageType messageType)
        {
            var reply = new Reply()
            {
                Prefix = "mx_admin_bot!admin@netadmin.example.com",
                Command = $"PRIVMSG {CurrentChannel}",
                Trailing = JsonSerializer.Serialize(new IrcMessage()
                {
                    CharacterId = pfpCharacterId,
                    MessageType = messageType,
                    AccountNickname = nickname,
                    Text = text,
                    SendTicks = DateTimeOffset.Now.Ticks,
                    StickerId = stickerId,
                }, typeof(IrcMessage)),
            }.ToString();

            StreamWriter.WriteLine(reply);
        }
    }
}
