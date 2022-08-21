using Nadeko.Snake;
using NadekoBot;
using Discord;

namespace CookieMedusa;

public sealed class MySnek : Snek
{
    [cmd]
    public async Task Hello(AnyContext ctx)
    {
        await ctx.Channel.SendMessageAsync($"Hello everyone!");
    }

    [cmd]
    public async Task Hello(AnyContext ctx, IUser target)
    {
        await ctx.ConfirmLocalizedAsync("hello", target);
    }
}