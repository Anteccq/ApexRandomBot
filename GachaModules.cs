using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace ApexRandomBot
{
    public class GachaModules : ModuleBase
    {
        private Legend _legend = new Legend();
        private Weapon _weapon = new Weapon();

        [Command("legend")]
        public async Task LegendGacha() =>
            await ReplyAsync(_legend.Gacha());

        [Command("weapon")]
        public async Task WeaponGacha()
        {
            var weaponTxt = 
                $"{_weapon.Gacha()}\n" +
                $"{_weapon.Gacha()}";
            await ReplyAsync(weaponTxt);
        }

        [Command("all")]
        public async Task All()
        {
            var weaponTxt =
                $"{_weapon.Gacha()}\n" +
                $"{_weapon.Gacha()}";
            var eb = new EmbedBuilder()
            {
                Color = Color.DarkBlue,
                Title = $"{_legend.Gacha()}",
                Description = weaponTxt
            };
            await ReplyAsync(message: ":upside_down:", embed: eb.Build());
        }

        [Command("help")]
        public async Task HelpAsync()
        {
            var footer = new EmbedFooterBuilder()
                .WithText("シーズン9まで対応しています。");

            var eb = new EmbedBuilder()
            {
                Color = Color.DarkGreen,
                Title = "コマンドリスト",
                Footer = footer
            };
            eb.AddField("レジェンド", "```!legend```");
            eb.AddField("武器", "```!weapon```");
            eb.AddField("レジェンド+武器", "```!all```");

            await ReplyAsync(embed: eb.Build());
        }
    }
}
