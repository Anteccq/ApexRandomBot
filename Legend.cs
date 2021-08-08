using System;

namespace ApexRandomBot
{
    public class Legend : IGacha{
        
        private readonly Random _rand;
        
        private readonly string[] _legends = {
            "バンガロール",
            "レイス",
            "ミラージュ",
            "オクタン",
            "レヴナント",
            "ホライゾン",
            "ジブラルタル",
            "コースティック",
            "ワットソン",
            "ランパート",
            "ライフライン",
            "ローバ",
            "ブラッドハウンド",
            "パスファインダー",
            "クリプト",
            "ヒューズ",
            "ヴァルキリー",
            "シア"
        };

        public Legend() => _rand = GatchaUtil.GenerateRandom();

        public string Gacha(){
            var index = _rand.Next(_legends.Length);
            return _legends[index];
        }
    }
}