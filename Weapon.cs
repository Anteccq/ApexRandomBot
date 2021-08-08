using System;

namespace ApexRandomBot
{
    public class Weapon : IGacha{

        private readonly Random _rand;

        private readonly string[] _weapons = {
            "フラットライン",
            "G7スカウト",
            "ヘムロック",
            "R301 カービン",
            "ハボック",
            "オルタネーター",
            "プラウラー",
            "R-99",
            "ボルト",
            "デヴォーション",
            "スピットファイア",
            "Lスター",
            "ロングボウ",
            "クレーバー",
            "トリプルテイク",
            "チャージライフル",
            "センチネル",
            "EVA8",
            "マスティフ",
            "モザンビーク",
            "ピースキーパー",
            "RE-45",
            "P2020",
            "ウィングマン",
            "30-30 リピーター",
            "ボセックボウ",
            "ランページLMG"
        };

        public Weapon() => _rand = GatchaUtil.GenerateRandom();

        public string Gacha(){
            var index = _rand.Next(_weapons.Length);
            return _weapons[index];
        }
    }
}