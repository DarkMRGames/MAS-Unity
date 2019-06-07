using Assets.Scripts.Api;

namespace Assets.Scripts.Monika
{
    public static class MonikaSprites
    {
        private const string
            pathMonikaFace = "Textures/Monika/Face/",
            pathMonikaHairs = "Textures/Monika/Hair/",
            pathMonikaClothes = "Textures/Monika/Clothes/";

        internal static SpritesCollection
            Eyebrows = new SpritesCollection(pathMonikaFace + "face-eyebrows-"){
                { "f", "furrowed" },
                { "u", "up" },
                { "k", "knit" },
                { "s", "mid" },
                { "t", "think" }
            },

            Eyes = new SpritesCollection(pathMonikaFace + "face-eyes-"){
                { "e", "normal" },
                { "w", "wide" },
                { "s", "sparkle" },
                { "t", "smug" },
                { "c", "crazy" },
                { "r", "right" },
                { "l", "left" },
                { "h", "closedhappy" },
                { "d", "closedsad" },
                { "k", "winkleft" },
                { "n", "winkright" }
            },

            Mouth = new SpritesCollection(pathMonikaFace + "face-mouth-"){
                { "a", "smile" },
                { "b", "big" },
                { "c", "smirk" },
                { "d", "small" },
                { "o", "gasp" },
                { "u", "smug" },
                { "w", "wide" },
                { "x", "disgust" },
                { "p", "pout" },
                { "t", "triangle" },
            };

        internal static NamedSpriteCollection<IMonikaHair> Hairs = new NamedSpriteCollection<IMonikaHair>
        {
            new MonikaHair(pathMonikaHairs + "Def/", "def", true),
            new MonikaHair(pathMonikaHairs + "Down/", "down", false)
        };

        internal static NamedSpriteCollection<IMonikaClothing> Clothes = new NamedSpriteCollection<IMonikaClothing>
        {
            new MonikaClothing(pathMonikaClothes + "Def/", "def"),
            new MonikaClothing(pathMonikaClothes + "SundressWhite/", "sundress_white")
        };
    }
}
