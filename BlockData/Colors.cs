using System.Drawing;

namespace BlockData
{
    public enum Colors
    {
        // Basic Blocks

        BlockBasicBlack = Color.FromArgb((int)1644825),
        BlockBasicDarkBlue = Color.FromArgb((int)4281684648),
        BlockBasicGreen = Color.FromArgb((int)4282558518),
        BlockBasicGrey = Color.FromArgb((int)4285427310),
        BlockBasicLightBlue = Color.FromArgb((int)4281704102),
        BlockBasicPurple = Color.FromArgb((int)4288099751),
        BlockBasicRed = Color.FromArgb((int)4289213780),
        BlockBasicYellow = Color.FromArgb((int)4287866933),

        // Beta Blocks

        BlockBetaBlue = Color.FromArgb((int)4283270342),
        BlockBetaGreen = Color.FromArgb((int)4283091074),
        BlockBetaGrey = Color.FromArgb((int)4288321167),
        BlockBetaPink = Color.FromArgb((int)4291715791),
        BlockBetaRed = Color.FromArgb((int)4291782224),
        BlockBetaYellow = Color.FromArgb((int)4291995973),

        // Boost Blocks

        BlockBoostDown = Color.FromArgb((int)16777216),
        BlockBoostLeft = Color.FromArgb((int)16777216),
        BlockBoostRight = Color.FromArgb((int)16777216),
        BlockBoostUp = Color.FromArgb((int)16777216),

        // Brick Blocks

        BlockBrickDarkGreen = Color.FromArgb((int)4280577869),
        BlockBrickLightGreen = Color.FromArgb((int)4282614544),
        BlockBrickPaleBrown = Color.FromArgb((int)4285488420),
        BlockBrickPurple = Color.FromArgb((int)4283311215),
        BlockBrickRed = Color.FromArgb((int)4285473833),
        BlockBrickSaturatedBrown = Color.FromArgb((int)4287315465),

        // Candy Blocks

        BlockCandyOneWayBlue = Color.FromArgb((int)3232612),
        BlockCandyOneWayGreen = Color.FromArgb((int)1263891),
        BlockCandyOneWayPink = Color.FromArgb((int)7810156),
        BlockCandyOneWayRed = Color.FromArgb((int)7411232),
        BlockCandySolidChocolate = Color.FromArgb((int)9253137),
        BlockCandySolidPink = Color.FromArgb((int)16487348),
        BlockCandySolidStripeyRedWhite = Color.FromArgb((int)12743796),
        BlockCandySolidStripeyYellowBlackPink = Color.FromArgb((int)10774865),

        // Christmas 2011

        BlockChristmas2011BlueBox = Color.FromArgb((int)5642622),
        BlockChristmas2011GreenBox = Color.FromArgb((int)5670165),
        BlockChristmas2011RedBox = Color.FromArgb((int)10044431),
        BlockChristmas2011WhiteBox = Color.FromArgb((int)12814468),
        BlockChristmas2011YellowBox = Color.FromArgb((int)8306196),

        // Coins

        BlockCoinBlue = Color.FromArgb((int)16777216),
        BlockCoinGold = Color.FromArgb((int)16777216),

        // Crown

        BlockCrown = Color.FromArgb((int)4282595615),

        // Doors

        BlockDoorBlue = Color.FromArgb((int)4281156764),
        BlockDoorCoinDoor = Color.FromArgb((int)4290285077),
        BlockDoorGreen = Color.FromArgb((int)4281834544),
        BlockDoorPurpleSwitchable = Color.FromArgb((int)7031201),
        BlockDoorRed = Color.FromArgb((int)4288425286),
        BlockDoorTimedDoor = Color.FromArgb((int)4079166),

        // Factory Blocks

        BlockFactory1 = Color.FromArgb((int)4285686091),
        BlockFactory2 = Color.FromArgb((int)4285426528),
        BlockFactory3 = Color.FromArgb((int)4287525711),
        BlockFactory4 = Color.FromArgb((int)4286533419),
        BlockFactory5 = Color.FromArgb((int)4285887861),

        // Gates

        BlockGateBlue = Color.FromArgb((int)4281156764),
        BlockGateCoinGate = Color.FromArgb((int)12094997),
        BlockGateGreen = Color.FromArgb((int)4281834544),
        BlockGatePurpleSwitchable = Color.FromArgb((int)2104613),
        BlockGateRed = Color.FromArgb((int)4288425286),
        BlockGateTimedGate = Color.FromArgb((int)6184542),

        // Glass Blocks

        BlockGlassDarkBlue = Color.FromArgb((int)4286487030),
        BlockGlassGreen = Color.FromArgb((int)4287822762),
        BlockGlassLightBlue = Color.FromArgb((int)4288011510),
        BlockGlassOrange = Color.FromArgb((int)4294359700),
        BlockGlassPink = Color.FromArgb((int)4293495798),
        BlockGlassPurple = Color.FromArgb((int)4289169910),
        BlockGlassRed = Color.FromArgb((int)4294480537),
        BlockGlassYellow = Color.FromArgb((int)4294498956),

        // Grass Blocks

        BlockGrass1 = Color.FromArgb((int)4547347),
        BlockGrass2 = Color.FromArgb((int)4547347),
        BlockGrass3 = Color.FromArgb((int)4547347),

        // Gravity Blocks

        BlockGravityDot = Color.FromArgb((int)16777216),
        BlockGravityLeft = Color.FromArgb((int)16777216),
        BlockGravityNothing = Color.FromArgb((int)16777216),
        BlockGravityRight = Color.FromArgb((int)16777216),
        BlockGravityUp = Color.FromArgb((int)16777216),

        // Halloween 2011

        BlockHalloween20111 = Color.FromArgb((int)6837332),
        BlockHalloween20112 = Color.FromArgb((int)6188660),

        // Key Blocks

        BlockKeyBlue = Color.FromArgb((int)4279900716),
        BlockKeyGreen = Color.FromArgb((int)4279905306),
        BlockKeyRed = Color.FromArgb((int)4281080346),

        // Metal Blocks

        BlockMetalRed = Color.FromArgb((int)4292835905),
        BlockMetalWhite = Color.FromArgb((int)4288783269),
        BlockMetalYellow = Color.FromArgb((int)4293962023),

        // Mineral Blocks

        BlockMineralDarkBlue = Color.FromArgb((int)4278190318),
        BlockMineralGreen = Color.FromArgb((int)4278251008),
        BlockMineralLightBlue = Color.FromArgb((int)4278251246),
        BlockMineralOrange = Color.FromArgb((int)4293818112),
        BlockMineralPink = Color.FromArgb((int)4293787886),
        BlockMineralRed = Color.FromArgb((int)4293787648),
        BlockMineralYellow = Color.FromArgb((int)4293848576),

        // Music Blocks

        BlockMusicDrum = Color.FromArgb((int)16777216),
        BlockMusicPiano = Color.FromArgb((int)16777216),

        // Ninja Blocks

        BlockNinjaGrey = Color.FromArgb((int)16777216),
        BlockNinjaWhite = Color.FromArgb((int)16777216),

        // Pirate Blocks

        BlockPirate1 = Color.FromArgb((int)11572068),
        BlockPirateChest = Color.FromArgb((int)11048021),

        // Prison Block

        BlockPrison = Color.FromArgb((int)8421504),

        // Sci-Fi Blocks

        BlockSciFiOneWayBlue = Color.FromArgb((int)8227772),
        BlockSciFiOneWayGreen = Color.FromArgb((int)7911811),
        BlockSciFiOneWayRed = Color.FromArgb((int)12352645),
        BlockSciFiSolidBlue = Color.FromArgb((int)3895965),
        BlockSciFiSolidBrown = Color.FromArgb((int)7098156),
        BlockSciFiSolidGrey = Color.FromArgb((int)8816262),
        BlockSciFiSolidRed = Color.FromArgb((int)10437440),
        BlockSciFiSolidWhite = Color.FromArgb((int)16777215),

        // Secret Blocks

        BlockSecretPassable = Color.FromArgb((int)16777216),
        BlockSecretUnpassable = Color.FromArgb((int)16777216),

        // Special Blocks

        BlockSpecial1 = Color.FromArgb((int)4287191826),
        BlockSpecial2 = Color.FromArgb((int)4291792930),
        BlockSpecialNormalBlack = Color.FromArgb((int)16777216),
        BlockSpecialFullyBlack = Color.FromArgb((int)16777216),

        // Summer 2011 Blocks

        BlockSummer2011Sand = Color.FromArgb((int)14269318),
        BlockSummer2011Sunshade = Color.FromArgb((int)16777216),

        // Switch Block

        BlockSwitchPurple = Color.FromArgb((int)3749188),

        // Viking Block

        BlockViking = Color.FromArgb((int)6908007),

        // Name = Color.FromArgb((int)color_value),
    }
}
