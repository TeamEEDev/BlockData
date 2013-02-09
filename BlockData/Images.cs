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

        //Swamp
        //public static readonly Bitmap BlockSwamp = new Bitmap(BlockData.Resources._369);

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

        //Prison
        public static readonly Bitmap DecorationPrison = new Bitmap(BlockData.Resources._261);

        //Pirate
        public static readonly Bitmap DecorationPirate1 = new Bitmap(BlockData.Resources._271);
        public static readonly Bitmap DecorationPirateSkull = new Bitmap(BlockData.Resources._272);

        //Viking
        public static readonly Bitmap DecorationVikingRedShield = new Bitmap(BlockData.Resources._273);
        public static readonly Bitmap DecorationVikingBlueShield = new Bitmap(BlockData.Resources._274);

        //Ninja
        public static readonly Bitmap DecorationNinja1 = new Bitmap(BlockData.Resources._276);
        public static readonly Bitmap DecorationNinja2 = new Bitmap(BlockData.Resources._277);
        public static readonly Bitmap DecorationNinja3 = new Bitmap(BlockData.Resources._278);
        public static readonly Bitmap DecorationNinja4 = new Bitmap(BlockData.Resources._279);
        public static readonly Bitmap DecorationNinja5 = new Bitmap(BlockData.Resources._280);
        public static readonly Bitmap DecorationNinja6 = new Bitmap(BlockData.Resources._281);
        public static readonly Bitmap DecorationNinja7 = new Bitmap(BlockData.Resources._282);
        public static readonly Bitmap DecorationNinja8 = new Bitmap(BlockData.Resources._283);
        public static readonly Bitmap DecorationNinja9 = new Bitmap(BlockData.Resources._284);

        //Water
        public static readonly Bitmap DecorationWater = new Bitmap(BlockData.Resources._300);

        //Cowboy
        public static readonly Bitmap DecorationCowboyPoleLit = new Bitmap(BlockData.Resources._285);
        public static readonly Bitmap DecorationCowboyPoleDark = new Bitmap(BlockData.Resources._286);
        public static readonly Bitmap DecorationCowboyDoorBrownLeft = new Bitmap(BlockData.Resources._287);
        public static readonly Bitmap DecorationCowboyDoorBrownRight = new Bitmap(BlockData.Resources._288);
        public static readonly Bitmap DecorationCowboyDoorRedLeft = new Bitmap(BlockData.Resources._289);
        public static readonly Bitmap DecorationCowboyDoorRedRight = new Bitmap(BlockData.Resources._290);
        public static readonly Bitmap DecorationCowboyDoorBlueLeft = new Bitmap(BlockData.Resources._291);
        public static readonly Bitmap DecorationCowboyDoorBlueRight = new Bitmap(BlockData.Resources._292);
        public static readonly Bitmap DecorationCowboyWindow = new Bitmap(BlockData.Resources._293);
        public static readonly Bitmap DecorationCowboyTableBrownLit = new Bitmap(BlockData.Resources._294);
        public static readonly Bitmap DecorationCowboyTableBrownDark = new Bitmap(BlockData.Resources._295);
        public static readonly Bitmap DecorationCowboyTableRedLit = new Bitmap(BlockData.Resources._296);
        public static readonly Bitmap DecorationCowboyTableRedDark = new Bitmap(BlockData.Resources._297);
        public static readonly Bitmap DecorationCowboyTableBlueLit = new Bitmap(BlockData.Resources._298);
        public static readonly Bitmap DecorationCowboyTableBlueDark = new Bitmap(BlockData.Resources._299);

        //Sand
        public static readonly Bitmap DecorationSandLightYellow = new Bitmap(BlockData.Resources._301);
        public static readonly Bitmap DecorationSandGrey = new Bitmap(BlockData.Resources._302);
        public static readonly Bitmap DecorationSandDarkerYellow = new Bitmap(BlockData.Resources._303);
        public static readonly Bitmap DecorationSandOrange = new Bitmap(BlockData.Resources._304);
        public static readonly Bitmap DecorationSandLightBrown = new Bitmap(BlockData.Resources._305);
        public static readonly Bitmap DecorationSandDarkBrown = new Bitmap(BlockData.Resources._306);

        //Cloud
        public static readonly Bitmap DecorationCloud1 = new Bitmap(BlockData.Resources._311);
        public static readonly Bitmap DecorationCloud2 = new Bitmap(BlockData.Resources._312);
        public static readonly Bitmap DecorationCloud3 = new Bitmap(BlockData.Resources._313);
        public static readonly Bitmap DecorationCloud4 = new Bitmap(BlockData.Resources._314);
        public static readonly Bitmap DecorationCloud5 = new Bitmap(BlockData.Resources._315);
        public static readonly Bitmap DecorationCloud6 = new Bitmap(BlockData.Resources._316);
        public static readonly Bitmap DecorationCloud7 = new Bitmap(BlockData.Resources._317);
        public static readonly Bitmap DecorationCloud8 = new Bitmap(BlockData.Resources._318);

        //Rocket
        public static readonly Bitmap DecorationRocketGreenSign = new Bitmap(BlockData.Resources._332);
        public static readonly Bitmap DecorationRocketRed = new Bitmap(BlockData.Resources._333);
        public static readonly Bitmap DecorationRocketBlue = new Bitmap(BlockData.Resources._334);
        public static readonly Bitmap DecorationRocketComputer = new Bitmap(BlockData.Resources._335);

        //Mars
        public static readonly Bitmap DecorationMars = new Bitmap(BlockData.Resources._336);

        //Prize Trophy
        public static readonly Bitmap DecorationPrizeTrophy = new Bitmap(BlockData.Resources._223);

        //Spring 2011
        public static readonly Bitmap DecorationSpring2011Grass1 = new Bitmap(BlockData.Resources._233);
        public static readonly Bitmap DecorationSpring2011Grass2 = new Bitmap(BlockData.Resources._234);
        public static readonly Bitmap DecorationSpring2011Grass3 = new Bitmap(BlockData.Resources._235);
        public static readonly Bitmap DecorationSpring2011OblongBush1 = new Bitmap(BlockData.Resources._236);
        public static readonly Bitmap DecorationSpring2011OblongBush2 = new Bitmap(BlockData.Resources._237);
        public static readonly Bitmap DecorationSpring2011OblongBush3 = new Bitmap(BlockData.Resources._238);
        public static readonly Bitmap DecorationSpring2011Flower = new Bitmap(BlockData.Resources._239);
        public static readonly Bitmap DecorationSpring2011GlobularBush = new Bitmap(BlockData.Resources._240);

        //New Years 2010
        public static readonly Bitmap DecorationNewYear2010Purple = new Bitmap(BlockData.Resources._244);
        public static readonly Bitmap DecorationNewYear2010Yellow = new Bitmap(BlockData.Resources._245);
        public static readonly Bitmap DecorationNewYear2010Blue = new Bitmap(BlockData.Resources._246);
        public static readonly Bitmap DecorationNewYear2010Red = new Bitmap(BlockData.Resources._247);
        public static readonly Bitmap DecorationNewYear2010Green = new Bitmap(BlockData.Resources._248);

        //Christmas 2010
        public static readonly Bitmap DecorationChristmas20101 = new Bitmap(BlockData.Resources._249);
        public static readonly Bitmap DecorationChristmas20102 = new Bitmap(BlockData.Resources._250);
        public static readonly Bitmap DecorationChristmas2010SnowFreeTree = new Bitmap(BlockData.Resources._251);
        public static readonly Bitmap DecorationChristmas2010SnowTree = new Bitmap(BlockData.Resources._252);
        public static readonly Bitmap DecorationChristmas2010SnowyFence = new Bitmap(BlockData.Resources._253);
        public static readonly Bitmap DecorationChristmas2010SnowFreeFence = new Bitmap(BlockData.Resources._254);

        //Easter 2012
        public static readonly Bitmap DecorationEaster2012BlueEgg = new Bitmap(BlockData.Resources._256);
        public static readonly Bitmap DecorationEaster2012PinkEgg = new Bitmap(BlockData.Resources._257);
        public static readonly Bitmap DecorationEaster2012YellowEgg = new Bitmap(BlockData.Resources._258);
        public static readonly Bitmap DecorationEaster2012RedEgg = new Bitmap(BlockData.Resources._259);
        public static readonly Bitmap DecorationEaster2012GreenEgg = new Bitmap(BlockData.Resources._260);

        //Windows
        public static readonly Bitmap DecorationWindowFullyTransparent = new Bitmap(BlockData.Resources._262);
        public static readonly Bitmap DecorationWindowTransparentLightGreen = new Bitmap(BlockData.Resources._263);
        public static readonly Bitmap DecorationWindowTransparentDarkGreen = new Bitmap(BlockData.Resources._264);
        public static readonly Bitmap DecorationWindowTransparentLightBlue = new Bitmap(BlockData.Resources._265);
        public static readonly Bitmap DecorationWindowTransparentDarkBlue = new Bitmap(BlockData.Resources._266);
        public static readonly Bitmap DecorationWindowTransparentPink = new Bitmap(BlockData.Resources._267);
        public static readonly Bitmap DecorationWindowTransparentRed = new Bitmap(BlockData.Resources._268);
        public static readonly Bitmap DecorationWindowTransparentOrange = new Bitmap(BlockData.Resources._269);
        public static readonly Bitmap DecorationWindowTransparentYellow = new Bitmap(BlockData.Resources._270);

        //Summer 2012
        public static readonly Bitmap DecorationSummer2012Ball = new Bitmap(BlockData.Resources._307);
        public static readonly Bitmap DecorationSummer2012Bucket = new Bitmap(BlockData.Resources._308);
        public static readonly Bitmap DecorationSummer2012Grubber = new Bitmap(BlockData.Resources._309);
        public static readonly Bitmap DecorationSummer2012Cocktail = new Bitmap(BlockData.Resources._310);

        //Warning
        public static readonly Bitmap DecorationWarningSignFire = new Bitmap(BlockData.Resources._319);
        public static readonly Bitmap DecorationWarningSignSkull = new Bitmap(BlockData.Resources._320);
        public static readonly Bitmap DecorationWarningSignLightning = new Bitmap(BlockData.Resources._321);
        public static readonly Bitmap DecorationWarningSignCross = new Bitmap(BlockData.Resources._322);
        public static readonly Bitmap DecorationWarningSignHorizontalLine = new Bitmap(BlockData.Resources._323);
        public static readonly Bitmap DecorationWarningSignVerticalLine = new Bitmap(BlockData.Resources._324);

        //Monster
        public static readonly Bitmap DecorationMonsterRockGroundBig = new Bitmap(BlockData.Resources._338);
        public static readonly Bitmap DecorationMonsterRockGroundSmall = new Bitmap(BlockData.Resources._339);
        public static readonly Bitmap DecorationMonsterRockCeiling = new Bitmap(BlockData.Resources._340);
        public static readonly Bitmap DecorationMonsterEyeOrange = new Bitmap(BlockData.Resources._341);
        public static readonly Bitmap DecorationMonsterEyeBlue = new Bitmap(BlockData.Resources._342);

        //Fog
        public static readonly Bitmap DecorationFogFilled = new Bitmap(BlockData.Resources._343);
        public static readonly Bitmap DecorationFog2 = new Bitmap(BlockData.Resources._344);
        public static readonly Bitmap DecorationFog3 = new Bitmap(BlockData.Resources._345);
        public static readonly Bitmap DecorationFog4 = new Bitmap(BlockData.Resources._346);
        public static readonly Bitmap DecorationFog5 = new Bitmap(BlockData.Resources._347);
        public static readonly Bitmap DecorationFog6 = new Bitmap(BlockData.Resources._348);
        public static readonly Bitmap DecorationFog7 = new Bitmap(BlockData.Resources._349);
        public static readonly Bitmap DecorationFog8 = new Bitmap(BlockData.Resources._350);
        public static readonly Bitmap DecorationFog9 = new Bitmap(BlockData.Resources._351);

        //Halloween 2012
        public static readonly Bitmap DecorationHalloween20121 = new Bitmap(BlockData.Resources._352);
        public static readonly Bitmap DecorationHalloween20122 = new Bitmap(BlockData.Resources._353);
        public static readonly Bitmap DecorationHalloween2012WiresVertical = new Bitmap(BlockData.Resources._354);
        public static readonly Bitmap DecorationHalloween2012WiresHorizontal = new Bitmap(BlockData.Resources._355);
        public static readonly Bitmap DecorationHalloween20125 = new Bitmap(BlockData.Resources._356);

        //Jungle
        public static readonly Bitmap DecorationJungleGrass = new Bitmap(BlockData.Resources._357);
        public static readonly Bitmap DecorationJungle2 = new Bitmap(BlockData.Resources._358);
        public static readonly Bitmap DecorationJungleTrophy = new Bitmap(BlockData.Resources._359);

        //Christmas 2012
        //public static readonly Bitmap DecorationChristmas2012BlueVertical = new Bitmap(BlockData.Resources._362);
        //public static readonly Bitmap DecorationChristmas2012BlueHorizontal = new Bitmap(BlockData.Resources._363);
        //public static readonly Bitmap DecorationChristmas2012BlueCross = new Bitmap(BlockData.Resources._364);
        //public static readonly Bitmap DecorationChristmas2012RedVertical = new Bitmap(BlockData.Resources._365);
        //public static readonly Bitmap DecorationChristmas2012RedHorizontal = new Bitmap(BlockData.Resources._366);
        //public static readonly Bitmap DecorationChristmas2012RedCross = new Bitmap(BlockData.Resources._367);

        #endregion

        #region Backgrounds

        //Basic
        public static readonly Bitmap BackgroundBasicGrey = new Bitmap(BlockData.Resources._500);
        public static readonly Bitmap BackgroundBasicDarkBlue = new Bitmap(BlockData.Resources._501);
        public static readonly Bitmap BackgroundBasicPurple = new Bitmap(BlockData.Resources._502);
        public static readonly Bitmap BackgroundBasicRed = new Bitmap(BlockData.Resources._503);
        public static readonly Bitmap BackgroundBasicYellow = new Bitmap(BlockData.Resources._504);
        public static readonly Bitmap BackgroundBasicGreen = new Bitmap(BlockData.Resources._505);
        public static readonly Bitmap BackgroundBasicLightBlue = new Bitmap(BlockData.Resources._506);

        //Brick
        public static readonly Bitmap BackgroundBrickSaturatedBrown = new Bitmap(BlockData.Resources._507);
        public static readonly Bitmap BackgroundBrickDarkGreen = new Bitmap(BlockData.Resources._508);
        public static readonly Bitmap BackgroundBrickPurple = new Bitmap(BlockData.Resources._509);
        public static readonly Bitmap BackgroundBrickLightGreen = new Bitmap(BlockData.Resources._510);
        public static readonly Bitmap BackgroundBrickRed = new Bitmap(BlockData.Resources._511);
        public static readonly Bitmap BackgroundBrickPaleBrown = new Bitmap(BlockData.Resources._512);

        //Candy
        public static readonly Bitmap BackgroundCandyPink = new Bitmap(BlockData.Resources._539);
        public static readonly Bitmap BackgroundCandyBlue = new Bitmap(BlockData.Resources._540);

        //Halloween 2011
        public static readonly Bitmap BackgroundHalloween20111 = new Bitmap(BlockData.Resources._541);
        public static readonly Bitmap BackgroundHalloween20112 = new Bitmap(BlockData.Resources._542);
        public static readonly Bitmap BackgroundHalloween20113 = new Bitmap(BlockData.Resources._543);
        public static readonly Bitmap BackgroundHalloween20114 = new Bitmap(BlockData.Resources._544);

        //Prison
        public static readonly Bitmap BackgroundPrisonBrickWall = new Bitmap(BlockData.Resources._550);
        public static readonly Bitmap BackgroundPrisonPicture = new Bitmap(BlockData.Resources._551);
        public static readonly Bitmap BackgroundPrisonWindowBlue = new Bitmap(BlockData.Resources._552);
        public static readonly Bitmap BackgroundPrisonWindowBlack = new Bitmap(BlockData.Resources._553);

        //Pirate
        public static readonly Bitmap BackgroundPirate1 = new Bitmap(BlockData.Resources._554);
        public static readonly Bitmap BackgroundPirate2 = new Bitmap(BlockData.Resources._555);
        public static readonly Bitmap BackgroundPirate3 = new Bitmap(BlockData.Resources._556);
        public static readonly Bitmap BackgroundPirate4 = new Bitmap(BlockData.Resources._557);
        public static readonly Bitmap BackgroundPirate5 = new Bitmap(BlockData.Resources._558);
        public static readonly Bitmap BackgroundPirate6 = new Bitmap(BlockData.Resources._559);
        public static readonly Bitmap BackgroundPirateSkull = new Bitmap(BlockData.Resources._560);

        //Viking
        public static readonly Bitmap BackgroundViking1 = new Bitmap(BlockData.Resources._561);
        public static readonly Bitmap BackgroundViking2 = new Bitmap(BlockData.Resources._562);
        public static readonly Bitmap BackgroundViking3 = new Bitmap(BlockData.Resources._563);

        //Ninja
        public static readonly Bitmap BackgroundNinjaWhiteWall = new Bitmap(BlockData.Resources._564);
        public static readonly Bitmap BackgroundNinjaGreyWall = new Bitmap(BlockData.Resources._565);
        public static readonly Bitmap BackgroundNinjaLitWindow = new Bitmap(BlockData.Resources._566);
        public static readonly Bitmap BackgroundNinjaDarkWindow = new Bitmap(BlockData.Resources._567);

        //Water
        public static readonly Bitmap BackgroundWaterBasic = new Bitmap(BlockData.Resources._574);
        public static readonly Bitmap BackgroundWaterOctopus = new Bitmap(BlockData.Resources._575);
        public static readonly Bitmap BackgroundWaterFish = new Bitmap(BlockData.Resources._576);
        public static readonly Bitmap BackgroundWaterSeaHorse = new Bitmap(BlockData.Resources._577);
        public static readonly Bitmap BackgroundWaterSeaweed = new Bitmap(BlockData.Resources._578);

        //Swamp
        //public static readonly Bitmap BackgroundSwamp = new Bitmap(BlockData.Resources._630);

        //Cowboy
        public static readonly Bitmap BackgroundCowboyBrownLit = new Bitmap(BlockData.Resources._568);
        public static readonly Bitmap BackgroundCowboyBrownDark = new Bitmap(BlockData.Resources._569);
        public static readonly Bitmap BackgroundCowboyRedLit = new Bitmap(BlockData.Resources._570);
        public static readonly Bitmap BackgroundCowboyRedDark = new Bitmap(BlockData.Resources._571);
        public static readonly Bitmap BackgroundCowboyBlueLit = new Bitmap(BlockData.Resources._572);
        public static readonly Bitmap BackgroundCowboyBlueDark = new Bitmap(BlockData.Resources._573);

        //Sand
        public static readonly Bitmap BackgroundSandLightYellow = new Bitmap(BlockData.Resources._579);
        public static readonly Bitmap BackgroundSandGrey = new Bitmap(BlockData.Resources._580);
        public static readonly Bitmap BackgroundSandDarkerYellow = new Bitmap(BlockData.Resources._581);
        public static readonly Bitmap BackgroundSandOrange = new Bitmap(BlockData.Resources._582);
        public static readonly Bitmap BackgroundSandLightBrown = new Bitmap(BlockData.Resources._583);
        public static readonly Bitmap BackgroundSandDarkBrown = new Bitmap(BlockData.Resources._584);

        //Industrial
        public static readonly Bitmap BackgroundIndustrialNoPlate = new Bitmap(BlockData.Resources._585);
        public static readonly Bitmap BackgroundIndustrialGreyPlate = new Bitmap(BlockData.Resources._586);
        public static readonly Bitmap BackgroundIndustrialBluePlate = new Bitmap(BlockData.Resources._587);
        public static readonly Bitmap BackgroundIndustrialGreenPlate = new Bitmap(BlockData.Resources._588);
        public static readonly Bitmap BackgroundIndustrialYellowPlate = new Bitmap(BlockData.Resources._589);

        //Timbered
        public static readonly Bitmap BackgroundTimberedHouseTopHay = new Bitmap(BlockData.Resources._590);
        public static readonly Bitmap BackgroundTimberedHouseTopRed = new Bitmap(BlockData.Resources._591);
        public static readonly Bitmap BackgroundTimberedHouseTopGrey = new Bitmap(BlockData.Resources._592);
        public static readonly Bitmap BackgroundTimbered4 = new Bitmap(BlockData.Resources._593);
        public static readonly Bitmap BackgroundTimbered5 = new Bitmap(BlockData.Resources._594);
        public static readonly Bitmap BackgroundTimbered6 = new Bitmap(BlockData.Resources._595);
        public static readonly Bitmap BackgroundTimbered7 = new Bitmap(BlockData.Resources._596);
        public static readonly Bitmap BackgroundTimbered8 = new Bitmap(BlockData.Resources._597);
        public static readonly Bitmap BackgroundTimbered9 = new Bitmap(BlockData.Resources._598);

        //Rocket
        public static readonly Bitmap BackgroundRocketWhite = new Bitmap(BlockData.Resources._601);
        public static readonly Bitmap BackgroundRocketBlue = new Bitmap(BlockData.Resources._602);
        public static readonly Bitmap BackgroundRocketGreen = new Bitmap(BlockData.Resources._603);
        public static readonly Bitmap BackgroundRocketRed = new Bitmap(BlockData.Resources._604);

        //Mars
        public static readonly Bitmap BackgroundMarsNoStars = new Bitmap(BlockData.Resources._605);
        public static readonly Bitmap BackgroundMarsSmallStar = new Bitmap(BlockData.Resources._606);
        public static readonly Bitmap BackgroundMarsBigStar = new Bitmap(BlockData.Resources._607);

        //Monster
        public static readonly Bitmap BackgroundMonsterNormal = new Bitmap(BlockData.Resources._608);
        public static readonly Bitmap BackgroundMonsterDark = new Bitmap(BlockData.Resources._609);

        //Checkered
        public static readonly Bitmap BackgroundCheckeredGrey = new Bitmap(BlockData.Resources._513);
        public static readonly Bitmap BackgroundCheckeredDarkBlue = new Bitmap(BlockData.Resources._514);
        public static readonly Bitmap BackgroundCheckeredPurple = new Bitmap(BlockData.Resources._515);
        public static readonly Bitmap BackgroundCheckeredRed = new Bitmap(BlockData.Resources._516);
        public static readonly Bitmap BackgroundCheckeredYellow = new Bitmap(BlockData.Resources._517);
        public static readonly Bitmap BackgroundCheckeredGreen = new Bitmap(BlockData.Resources._518);
        public static readonly Bitmap BackgroundCheckeredLightBlue = new Bitmap(BlockData.Resources._519);

        //Dark
        public static readonly Bitmap BackgroundDarkGrey = new Bitmap(BlockData.Resources._520);
        public static readonly Bitmap BackgroundDarkDarkBlue = new Bitmap(BlockData.Resources._521);
        public static readonly Bitmap BackgroundDarkPurple = new Bitmap(BlockData.Resources._522);
        public static readonly Bitmap BackgroundDarkRed = new Bitmap(BlockData.Resources._523);
        public static readonly Bitmap BackgroundDarkYellow = new Bitmap(BlockData.Resources._524);
        public static readonly Bitmap BackgroundDarkGreen = new Bitmap(BlockData.Resources._525);
        public static readonly Bitmap BackgroundDarkLightBlue = new Bitmap(BlockData.Resources._526);

        //Pastel
        public static readonly Bitmap BackgroundPastelYellow = new Bitmap(BlockData.Resources._527);
        public static readonly Bitmap BackgroundPastelDarkerGreen = new Bitmap(BlockData.Resources._528);
        public static readonly Bitmap BackgroundPastelLimeGreen = new Bitmap(BlockData.Resources._529);
        public static readonly Bitmap BackgroundPastelLightBlue = new Bitmap(BlockData.Resources._530);
        public static readonly Bitmap BackgroundPastelDarkerBlue = new Bitmap(BlockData.Resources._531);
        public static readonly Bitmap BackgroundPastelRed = new Bitmap(BlockData.Resources._532);

        //Canvas
        public static readonly Bitmap BackgroundCanvasSaturatedBrown = new Bitmap(BlockData.Resources._533);
        public static readonly Bitmap BackgroundCanvasPaleBrown = new Bitmap(BlockData.Resources._534);
        public static readonly Bitmap BackgroundCanvasYellow = new Bitmap(BlockData.Resources._535);
        public static readonly Bitmap BackgroundCanvasGreen = new Bitmap(BlockData.Resources._536);
        public static readonly Bitmap BackgroundCanvasBlue = new Bitmap(BlockData.Resources._537);
        public static readonly Bitmap BackgroundCanvasGrey = new Bitmap(BlockData.Resources._538);

        //Carnival
        public static readonly Bitmap BackgroundCarnivalStripeyRedYellow = new Bitmap(BlockData.Resources._545);
        public static readonly Bitmap BackgroundCarnivalStripeyPurpleBlue = new Bitmap(BlockData.Resources._546);
        public static readonly Bitmap BackgroundCarnivalPink = new Bitmap(BlockData.Resources._547);
        public static readonly Bitmap BackgroundCarnivalChecker = new Bitmap(BlockData.Resources._548);
        public static readonly Bitmap BackgroundCarnivalGreen = new Bitmap(BlockData.Resources._549);

        //Normal
        public static readonly Bitmap BackgroundNormalGrey = new Bitmap(BlockData.Resources._610);
        public static readonly Bitmap BackgroundNormalDarkBlue = new Bitmap(BlockData.Resources._611);
        public static readonly Bitmap BackgroundNormalPurple = new Bitmap(BlockData.Resources._612);
        public static readonly Bitmap BackgroundNormalRed = new Bitmap(BlockData.Resources._613);
        public static readonly Bitmap BackgroundNormalYellow = new Bitmap(BlockData.Resources._614);
        public static readonly Bitmap BackgroundNormalGreen = new Bitmap(BlockData.Resources._615);
        public static readonly Bitmap BackgroundNormalLightBlue = new Bitmap(BlockData.Resources._616);

        //Jungle Ruins
        public static readonly Bitmap BackgroundJungleRuinsGrey = new Bitmap(BlockData.Resources._617);
        public static readonly Bitmap BackgroundJungleRuinsRed = new Bitmap(BlockData.Resources._618);
        public static readonly Bitmap BackgroundJungleRuinsBlue = new Bitmap(BlockData.Resources._619);
        public static readonly Bitmap BackgroundJungleRuinsYellow = new Bitmap(BlockData.Resources._620);

        //Jungle
        public static readonly Bitmap BackgroundJungleLight = new Bitmap(BlockData.Resources._621);
        public static readonly Bitmap BackgroundJungleNormal = new Bitmap(BlockData.Resources._622);
        public static readonly Bitmap BackgroundJungleDark = new Bitmap(BlockData.Resources._623);

        //Christmas 2012
        //public static readonly Bitmap BackgroundChristmas2012Yellow = new Bitmap(BlockData.Resources._624);
        //public static readonly Bitmap BackgroundChristmas2012Green = new Bitmap(BlockData.Resources._625);
        //public static readonly Bitmap BackgroundChristmas2012Blue = new Bitmap(BlockData.Resources._626);

        //Lava
        //public static readonly Bitmap BackgroundLavaYellow = new Bitmap(BlockData.Resources._627);
        //public static readonly Bitmap BackgroundLavaOrange = new Bitmap(BlockData.Resources._628);
        //public static readonly Bitmap BackgroundLavaRed = new Bitmap(BlockData.Resources._629);

        #endregion

        //public static readonly Bitmap Name = new Bitmap(BlockData.Resources._[block-id]);
    }
}
