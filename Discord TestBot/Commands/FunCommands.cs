using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_TestBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("Ping")]
        [Description("Gibt Pong zurück")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }


        [Command("Addieren")]
        [Description("Addiert zwei Zahlen")]
        public async Task Add(
            CommandContext ctx,
            [Description("1. Zahl")] int numberOne,
            [Description("2. Zahl")] int numberTwo)
        {
            await ctx.Channel.SendMessageAsync("Der Rechenboss hat als Ergebnis " + (numberOne + numberTwo).ToString()).ConfigureAwait(false);
        }

        [Command("Subtrahieren")]
        [Description("Subtrahiert zwei Zahlen")]
        public async Task Subtract(
            CommandContext ctx,
            [Description("1. Zahl")] int numberOne,
            [Description("2. Zahl")] int numberTwo)
        {
            await ctx.Channel.SendMessageAsync("Der Rechenboss hat als Ergebnis " + (numberOne - numberTwo).ToString()).ConfigureAwait(false);
        }

        [Command("multiplizieren")]
        [Description("Multipliziert zwei Zahlen")]
        public async Task Multiply(
            CommandContext ctx,
            [Description("1. Zahl")] int numberOne,
            [Description("2. Zahl")] int numberTwo)
        {
            await ctx.Channel.SendMessageAsync("Der Rechenboss hat als Ergebnis " + (numberOne * numberTwo).ToString()).ConfigureAwait(false);
        }

        [Command("Dividieren")]
        [Description("Dividiert zwei Zahlen")]
        public async Task Divide(
            CommandContext ctx,
            [Description("1. Zahl")] int numberOne,
            [Description("2. Zahl")] int numberTwo)
        {
            await ctx.Channel.SendMessageAsync("Der Rechenboss hat als Ergebnis " + (numberOne / numberTwo).ToString()).ConfigureAwait(false);
        }


        [Command("länge")]
        [Description("Finde deine wahre Länge heraus")]
        public async Task Laenge(CommandContext ctx)
        {
            Random random = new Random();
            string[] länge = new string[7];
            länge[0] = "=";
            länge[1] = "==";
            länge[2] = "===";
            länge[3] = "====";
            länge[4] = "=====";
            länge[5] = "======";
            länge[6] = "=======";
            await ctx.Channel.SendMessageAsync(ctx.Member.Username + "'s Schlong ist so lang: 8" + länge[random.Next(7)] + "D");
        }

    }
}
