using System.Drawing;

namespace BlockData
{
    public class Images
    {
        #region Blocks
        //Gravity
        public static readonly Bitmap BlockGravityNothing = new Bitmap(BlockData.Resources._0);
        public static readonly Bitmap BlockGravityLeft = new Bitmap(BlockData.Resources._1);
        public static readonly Bitmap BlockGravityUp = new Bitmap(BlockData.Resources._2);
        public static readonly Bitmap BlockGravityRight = new Bitmap(BlockData.Resources._3);
        public static readonly Bitmap BlockGravityDot = new Bitmap(BlockData.Resources._4);

        //Crown
        public static readonly Bitmap BlockCrown = new Bitmap(BlockData.Resources._5);

        //Keys
        public static readonly Bitmap BlockKeyRed = new Bitmap(BlockData.Resources._6);
        public static readonly Bitmap BlockKeyGreen = new Bitmap(BlockData.Resources._7);
        public static readonly Bitmap BlockKeyBlue = new Bitmap(BlockData.Resources._8);

        //Basic Block Pack
        public static readonly Bitmap BlockBasicGrey = new Bitmap(BlockData.Resources._9);
        public static readonly Bitmap BlockBasicBlue = new Bitmap(BlockData.Resources._10);
        public static readonly Bitmap BlockBasicPurple = new Bitmap(BlockData.Resources._11);
        public static readonly Bitmap BlockBasicRed = new Bitmap(BlockData.Resources._12);
        public static readonly Bitmap BlockBasicYellow = new Bitmap(BlockData.Resources._13);
        public static readonly Bitmap BlockBasicGreen = new Bitmap(BlockData.Resources._14);
        public static readonly Bitmap BlockBasicLightBlue = new Bitmap(BlockData.Resources._15);
        public static readonly Bitmap BlockBasicBlack = new Bitmap(BlockData.Resources._182);

        //Brick Pack
        public static readonly Bitmap BlockBrickSaturatedBrown = new Bitmap(BlockData.Resources._16);
        public static readonly Bitmap BlockBrickDarkGreen = new Bitmap(BlockData.Resources._17);
        public static readonly Bitmap BlockBrickPurple = new Bitmap(BlockData.Resources._18);
        public static readonly Bitmap BlockBrickLightGreen = new Bitmap(BlockData.Resources._19);
        public static readonly Bitmap BlockBrickRed = new Bitmap(BlockData.Resources._20);
        public static readonly Bitmap BlockBrickPaleBrown = new Bitmap(BlockData.Resources._21);

        //Special Blocks Pack
        public static readonly Bitmap BlockSpecial1 = new Bitmap(BlockData.Resources._22);
        public static readonly Bitmap BlockSpecial2 = new Bitmap(BlockData.Resources._32);
        public static readonly Bitmap BlockSpecialNormalBlack = new Bitmap(BlockData.Resources._33);
        public static readonly Bitmap BlockSpecialFullyBlack = new Bitmap(BlockData.Resources._44);

        //Doors Pack
        public static readonly Bitmap BlockDoorRed = new Bitmap(BlockData.Resources._23);
        public static readonly Bitmap BlockDoorGreen = new Bitmap(BlockData.Resources._24);
        public static readonly Bitmap BlockDoorBlue = new Bitmap(BlockData.Resources._25);
        public static readonly Bitmap BlockDoorCoinDoor = new Bitmap(BlockData.Resources._43);
        //public static readonly Bitmap BlockDoorTimedDoor = new Bitmap(BlockData.Resources._156);
        public static readonly Bitmap BlockDoorPurpleSwitcha_le = new Bitmap(BlockData.Resources._184);

        //Gates Pack
        public static readonly Bitmap BlockGateRed = new Bitmap(BlockData.Resources._26);
        public static readonly Bitmap BlockGateGreen = new Bitmap(BlockData.Resources._27);
        public static readonly Bitmap BlockGateBlue = new Bitmap(BlockData.Resources._28);
        //public static readonly Bitmap BlockGateTimedGate = new Bitmap(BlockData.Resources._157);
        //public static readonly Bitmap BlockGateCoinGate = new Bitmap(BlockData.Resources._165);
        //BlockGatePurpleSwitchable id=185

        //Metal Pack
        public static readonly Bitmap BlockMetalWhite = new Bitmap(BlockData.Resources._29);
        public static readonly Bitmap BlockMetalRed = new Bitmap(BlockData.Resources._30);
        public static readonly Bitmap BlockMetalYellow = new Bitmap(BlockData.Resources._31);

        //Grass Pack
        public static readonly Bitmap BlockGrass1 = new Bitmap(BlockData.Resources._34);
        public static readonly Bitmap BlockGrass2 = new Bitmap(BlockData.Resources._35);
        public static readonly Bitmap BlockGrass3 = new Bitmap(BlockData.Resources._36);

        //Beta Pack
        public static readonly Bitmap BlockBetaPink = new Bitmap(BlockData.Resources._37);
        public static readonly Bitmap BlockBetaGreen = new Bitmap(BlockData.Resources._38);
        public static readonly Bitmap BlockBetaBlue = new Bitmap(BlockData.Resources._39);
        public static readonly Bitmap BlockBetaRed = new Bitmap(BlockData.Resources._40);
        public static readonly Bitmap BlockBetaYellow = new Bitmap(BlockData.Resources._41);
        public static readonly Bitmap BlockBetaGrey = new Bitmap(BlockData.Resources._42);

        //Factory Pack
        public static readonly Bitmap BlockFactory1 = new Bitmap(BlockData.Resources._45);
        public static readonly Bitmap BlockFactory2 = new Bitmap(BlockData.Resources._46);
        public static readonly Bitmap BlockFactory3 = new Bitmap(BlockData.Resources._47);
        public static readonly Bitmap BlockFactory4 = new Bitmap(BlockData.Resources._48);
        public static readonly Bitmap BlockFactory5 = new Bitmap(BlockData.Resources._49);

        //Secrets
        public static readonly Bitmap BlockSecretUnpassa_le = new Bitmap(BlockData.Resources._50);
        public static readonly Bitmap BlockSecretPassa_le = new Bitmap(BlockData.Resources._243);

        //Glass Pack
        public static readonly Bitmap BlockGlassRed = new Bitmap(BlockData.Resources._51);
        public static readonly Bitmap BlockGlassPink = new Bitmap(BlockData.Resources._52);
        public static readonly Bitmap BlockGlassPurple = new Bitmap(BlockData.Resources._53);
        public static readonly Bitmap BlockGlassDarkBlue = new Bitmap(BlockData.Resources._54);
        public static readonly Bitmap BlockGlassLightBlue = new Bitmap(BlockData.Resources._55);
        public static readonly Bitmap BlockGlassGreen = new Bitmap(BlockData.Resources._56);
        public static readonly Bitmap BlockGlassYellow = new Bitmap(BlockData.Resources._57);
        public static readonly Bitmap BlockGlassOrange = new Bitmap(BlockData.Resources._58);
        
        //Summer 2011 Pack
        public static readonly Bitmap BlockSummer2011Sand = new Bitmap(BlockData.Resources._59);

        //Candy Pack
        public static readonly Bitmap BlockCandySolidPink = new Bitmap(BlockData.Resources._60);
        public static readonly Bitmap BlockCandyOneWayPink = new Bitmap(BlockData.Resources._61);
        public static readonly Bitmap BlockCandyOneWayRed = new Bitmap(BlockData.Resources._62);
        public static readonly Bitmap BlockCandyOneWayBlue = new Bitmap(BlockData.Resources._63);
        public static readonly Bitmap BlockCandyOneWayGreen = new Bitmap(BlockData.Resources._64);
        public static readonly Bitmap BlockCandySolidStripeyRedWhite = new Bitmap(BlockData.Resources._65);
        public static readonly Bitmap BlockCandySolidStripeyYellowBlackPink = new Bitmap(BlockData.Resources._66);
        public static readonly Bitmap BlockCandySolidChocolate = new Bitmap(BlockData.Resources._67);

        //Halloween 2011 Pack
        public static readonly Bitmap BlockHalloween20111 = new Bitmap(BlockData.Resources._68);
        public static readonly Bitmap BlockHalloween20112 = new Bitmap(BlockData.Resources._69);

        //Mineral Pack
        public static readonly Bitmap BlockMineralRed = new Bitmap(BlockData.Resources._70);
        public static readonly Bitmap BlockMineralPink = new Bitmap(BlockData.Resources._71);
        public static readonly Bitmap BlockMineralDarkBlue = new Bitmap(BlockData.Resources._72);
        public static readonly Bitmap BlockMineralLightBlue = new Bitmap(BlockData.Resources._73);
        public static readonly Bitmap BlockMineralGreen = new Bitmap(BlockData.Resources._74);
        public static readonly Bitmap BlockMineralYellow = new Bitmap(BlockData.Resources._75);
        public static readonly Bitmap BlockMineralOrange = new Bitmap(BlockData.Resources._76);

        //Music Pack
        public static readonly Bitmap BlockMusicPiano = new Bitmap(BlockData.Resources._77);
        public static readonly Bitmap BlockMusicDrum = new Bitmap(BlockData.Resources._83);

        //Christmas 2011 Pack
        public static readonly Bitmap BlockChristmas2011YellowBox = new Bitmap(BlockData.Resources._78);
        public static readonly Bitmap BlockChristmas2011WhiteBox = new Bitmap(BlockData.Resources._79);
        public static readonly Bitmap BlockChristmas2011RedBox = new Bitmap(BlockData.Resources._80);
        public static readonly Bitmap BlockChristmas2011BlueBox = new Bitmap(BlockData.Resources._81);
        public static readonly Bitmap BlockChristmas2011GreenBox = new Bitmap(BlockData.Resources._82);

        //SciFi Pack
        public static readonly Bitmap BlockSciFiSolidRed = new Bitmap(BlockData.Resources._84);
        public static readonly Bitmap BlockSciFiSolidBlue = new Bitmap(BlockData.Resources._85);
        public static readonly Bitmap BlockSciFiSolidGrey = new Bitmap(BlockData.Resources._86);
        public static readonly Bitmap BlockSciFiSolidWhite = new Bitmap(BlockData.Resources._87);
        public static readonly Bitmap BlockSciFiSolidBrown = new Bitmap(BlockData.Resources._88);
        public static readonly Bitmap BlockSciFiOneWayRed = new Bitmap(BlockData.Resources._89);
        public static readonly Bitmap BlockSciFiOneWayBlue = new Bitmap(BlockData.Resources._90);
        public static readonly Bitmap BlockSciFiOneWayGreen = new Bitmap(BlockData.Resources._91);

        //Prison Pack
        public static readonly Bitmap BlockPrison = new Bitmap(BlockData.Resources._92);

        //Pirate Pack
        public static readonly Bitmap BlockPirate1 = new Bitmap(BlockData.Resources._93);
        public static readonly Bitmap BlockPirateChest = new Bitmap(BlockData.Resources._94);

        //Viking Pack
        public static readonly Bitmap BlockViking = new Bitmap(BlockData.Resources._95);

        //Ninja Pack
        public static readonly Bitmap BlockNinjaWhite = new Bitmap(BlockData.Resources._96);
        public static readonly Bitmap BlockNinjaGrey = new Bitmap(BlockData.Resources._97);

        //Coins
        public static readonly Bitmap BlockCoinGold = new Bitmap(BlockData.Resources._100);
        public static readonly Bitmap BlockCoinBlue = new Bitmap(BlockData.Resources._101);

        //Switch
        public static readonly Bitmap BlockSwitchPurple = new Bitmap(BlockData.Resources._113);

        //Boosts
        public static readonly Bitmap BlockBoostLeft = new Bitmap(BlockData.Resources._114);
        public static readonly Bitmap BlockBoostRight = new Bitmap(BlockData.Resources._115);
        public static readonly Bitmap BlockBoostUp = new Bitmap(BlockData.Resources._116);
        public static readonly Bitmap BlockBoostDown = new Bitmap(BlockData.Resources._117);

        //Water
        public static readonly Bitmap BlockWater = new Bitmap(BlockData.Resources._119);

        //Ladders
        public static readonly Bitmap BlockLadderCastle = new Bitmap(BlockData.Resources._118);
        public static readonly Bitmap BlockLadderNinja = new Bitmap(BlockData.Resources._120);
        public static readonly Bitmap BlockLadderJungleVertical = new Bitmap(BlockData.Resources._98);
        public static readonly Bitmap BlockLadderJungleHorizontal = new Bitmap(BlockData.Resources._99);

        //Tools
        public static readonly Bitmap BlockToolWinTrophy = new Bitmap(BlockData.Resources._121);
        public static readonly Bitmap BlockToolSpawnPoint = new Bitmap(BlockData.Resources._255);
        //public static readonly Bitmap BlockToolCheckpoint = new Bitmap(BlockData.Resources._360);

        //Cowboy Pack
        public static readonly Bitmap BlockCowboyBrownLit = new Bitmap(BlockData.Resources._122);
        public static readonly Bitmap BlockCowboyRedLit = new Bitmap(BlockData.Resources._123);
        public static readonly Bitmap BlockCowboyBlueLit = new Bitmap(BlockData.Resources._124);
        public static readonly Bitmap BlockCowboyBrownDark = new Bitmap(BlockData.Resources._125);
        public static readonly Bitmap BlockCowboyRedDark = new Bitmap(BlockData.Resources._126);
        public static readonly Bitmap BlockCowboyBlueDark = new Bitmap(BlockData.Resources._127);

        //Plastic Pack
        public static readonly Bitmap BlockPlasticLightGreen = new Bitmap(BlockData.Resources._128);
        public static readonly Bitmap BlockPlasticRed = new Bitmap(BlockData.Resources._129);
        public static readonly Bitmap BlockPlasticYellow = new Bitmap(BlockData.Resources._130);
        public static readonly Bitmap BlockPlasticLightBlue = new Bitmap(BlockData.Resources._131);
        public static readonly Bitmap BlockPlasticDarkBlue = new Bitmap(BlockData.Resources._132);
        public static readonly Bitmap BlockPlasticPink = new Bitmap(BlockData.Resources._133);
        public static readonly Bitmap BlockPlasticDarkGreen = new Bitmap(BlockData.Resources._134);
        public static readonly Bitmap BlockPlasticOrange = new Bitmap(BlockData.Resources._135);

        //Sand Pack
        public static readonly Bitmap BlockSandLightYellow = new Bitmap(BlockData.Resources._137);
        public static readonly Bitmap BlockSandGrey = new Bitmap(BlockData.Resources._138);
        public static readonly Bitmap BlockSandDarkerYellow = new Bitmap(BlockData.Resources._139);
        public static readonly Bitmap BlockSandOrange = new Bitmap(BlockData.Resources._140);
        public static readonly Bitmap BlockSandLightBrown = new Bitmap(BlockData.Resources._141);
        public static readonly Bitmap BlockSandDarkBrown = new Bitmap(BlockData.Resources._142);

        //Cloud Pack
        public static readonly Bitmap BlockCloud = new Bitmap(BlockData.Resources._143);

        //Plates
        public static readonly Bitmap BlockPlateIron1 = new Bitmap(BlockData.Resources._144);
        public static readonly Bitmap BlockPlateIron2 = new Bitmap(BlockData.Resources._145);

        //Industrial Pack
        public static readonly Bitmap BlockIndustrialOneWay = new Bitmap(BlockData.Resources._146);
        public static readonly Bitmap BlockIndustrial2 = new Bitmap(BlockData.Resources._147);
        public static readonly Bitmap BlockIndustrial3 = new Bitmap(BlockData.Resources._148);
        public static readonly Bitmap BlockIndustrial4 = new Bitmap(BlockData.Resources._149);
        public static readonly Bitmap BlockIndustrialConveyerBelt1 = new Bitmap(BlockData.Resources._150);
        public static readonly Bitmap BlockIndustrialConveyerBelt2 = new Bitmap(BlockData.Resources._151);
        public static readonly Bitmap BlockIndustrialConveyerBelt3 = new Bitmap(BlockData.Resources._152);
        public static readonly Bitmap BlockIndustrialConveyerBelt4 = new Bitmap(BlockData.Resources._153);
        
        //Timbered Pack
        public static readonly Bitmap BlockTimbered = new Bitmap(BlockData.Resources._154);

        //Pipe Pack
        public static readonly Bitmap BlockPipeHoleOnLeft = new Bitmap(BlockData.Resources._166);
        public static readonly Bitmap BlockPipeHorizontalMiddle = new Bitmap(BlockData.Resources._167);
        public static readonly Bitmap BlockPipeHoleOnRight = new Bitmap(BlockData.Resources._168);
        public static readonly Bitmap BlockPipeHoleOnUp = new Bitmap(BlockData.Resources._169);
        public static readonly Bitmap BlockPipeVerticalMiddle = new Bitmap(BlockData.Resources._170);
        public static readonly Bitmap BlockPipeHoleOnDown = new Bitmap(BlockData.Resources._171);

        //Rocket Pack
        public static readonly Bitmap BlockRocketWhite = new Bitmap(BlockData.Resources._172);
        public static readonly Bitmap BlockRocketBlue = new Bitmap(BlockData.Resources._173);
        public static readonly Bitmap BlockRocketGreen = new Bitmap(BlockData.Resources._174);
        public static readonly Bitmap BlockRocketRed = new Bitmap(BlockData.Resources._175);

        //Mars Pack
        public static readonly Bitmap BlockMars1 = new Bitmap(BlockData.Resources._176);
        public static readonly Bitmap BlockMars2 = new Bitmap(BlockData.Resources._177);
        public static readonly Bitmap BlockMars3 = new Bitmap(BlockData.Resources._178);
        public static readonly Bitmap BlockMars4 = new Bitmap(BlockData.Resources._179);
        public static readonly Bitmap BlockMars5 = new Bitmap(BlockData.Resources._180);
        public static readonly Bitmap BlockMars6 = new Bitmap(BlockData.Resources._181);

        //Checkered Pack
        public static readonly Bitmap BlockCheckeredGrey = new Bitmap(BlockData.Resources._186);
        public static readonly Bitmap BlockCheckeredDarkBlue = new Bitmap(BlockData.Resources._187);
        public static readonly Bitmap BlockCheckeredPurple = new Bitmap(BlockData.Resources._188);
        public static readonly Bitmap BlockCheckeredRed = new Bitmap(BlockData.Resources._189);
        public static readonly Bitmap BlockCheckeredYellow = new Bitmap(BlockData.Resources._190);
        public static readonly Bitmap BlockCheckeredGreen = new Bitmap(BlockData.Resources._191);
        public static readonly Bitmap BlockCheckeredLightBlue = new Bitmap(BlockData.Resources._192);

        //Jungle Ruins Pack
        public static readonly Bitmap BlockJungleRuinsSolidRoundedEdgeFace = new Bitmap(BlockData.Resources._193);
        public static readonly Bitmap BlockJungleRuinsOneWay = new Bitmap(BlockData.Resources._194);
        public static readonly Bitmap BlockJungleRuinsSolidNonRoundedGrey = new Bitmap(BlockData.Resources._195);
        public static readonly Bitmap BlockJungleRuinsSolidRed = new Bitmap(BlockData.Resources._196);
        public static readonly Bitmap BlockJungleRuinsSolidBlue = new Bitmap(BlockData.Resources._197);
        public static readonly Bitmap BlockJungleRuinsSolidYellow = new Bitmap(BlockData.Resources._198);

        public static readonly Bitmap BlockJungleVase = new Bitmap(BlockData.Resources._199);

        //Diamond
        public static readonly Bitmap BlockDiamond = new Bitmap(BlockData.Resources._241);

        //Portal
        public static readonly Bitmap BlockPortal = new Bitmap(BlockData.Resources._242);

        //Cake
        public static readonly Bitmap BlockCake = new Bitmap(BlockData.Resources._337);

        //Hazards
        //public static readonly Bitmap BlockHazardSpike = new Bitmap(BlockData.Resources._361);
        //public static readonly Bitmap BlockHazardFire = new Bitmap(BlockData.Resources._368);

        //Lava Pack
        //public static readonly Bitmap BlockLavaYellow = new Bitmap(BlockData.Resources._202);
        //public static readonly Bitmap BlockLavaOrange = new Bitmap(BlockData.Resources._203);
        //public static readonly Bitmap BlockLavaRed = new Bitmap(BlockData.Resources._204);
        #endregion

        #region Decorations

        //Summer 2011
        public static readonly Bitmap DecorationSummer2011Sunshade = new Bitmap(BlockData.Resources._228);
        public static readonly Bitmap DecorationSummer20111 = new Bitmap(BlockData.Resources._229);
        public static readonly Bitmap DecorationSummer20112 = new Bitmap(BlockData.Resources._230);
        public static readonly Bitmap DecorationSummer2011Rock = new Bitmap(BlockData.Resources._231);

        //Candy
        public static readonly Bitmap DecorationCandy = new Bitmap(BlockData.Resources._227);

        //Halloween 2011
        public static readonly Bitmap DecorationHalloween2011GraveStone = new Bitmap(BlockData.Resources._224);
        public static readonly Bitmap DecorationHalloween20112 = new Bitmap(BlockData.Resources._225);
        public static readonly Bitmap DecorationHalloween20113 = new Bitmap(BlockData.Resources._226);

        //Christmas 2011
        public static readonly Bitmap DecorationChristmas2011Star = new Bitmap(BlockData.Resources._218);
        public static readonly Bitmap DecorationChristmas2011Wreath = new Bitmap(BlockData.Resources._219);
        public static readonly Bitmap DecorationChristmas2011SphereBlue = new Bitmap(BlockData.Resources._220);
        public static readonly Bitmap DecorationChristmas2011SphereGreen = new Bitmap(BlockData.Resources._221);
        public static readonly Bitmap DecorationChristmas2011SphereRed = new Bitmap(BlockData.Resources._222);

        #endregion

        //public static readonly Bitmap Name = new Bitmap(BlockData.Resources._[block-id]);
    }
}
