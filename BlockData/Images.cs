using System.Drawing;

namespace BlockData
{
    public enum Images
    {
        //Gravity
        BlockGravityNothing = new Bitmap(BlockData.Resources.b0),
        BlockGravityLeft = new Bitmap(BlockData.Resources.b1),
        BlockGravityUp = new Bitmap(BlockData.Resources.b2),
        BlockGravityRight = new Bitmap(BlockData.Resources.b3),
        BlockGravityDot = new Bitmap(BlockData.Resources.b4),

        //Crown
        BlockCrown = new Bitmap(BlockData.Resources.b5),

        //Keys
        BlockKeyRed = new Bitmap(BlockData.Resources.b6),
        BlockKeyGreen = new Bitmap(BlockData.Resources.b7),
        BlockKeyBlue = new Bitmap(BlockData.Resources.b8),

        //Basic Block Pack
        BlockBasicGrey = new Bitmap(BlockData.Resources.b9),
        BlockBasicBlue = new Bitmap(BlockData.Resources.b10),
        BlockBasicPurple = new Bitmap(BlockData.Resources.b11),
        BlockBasicRed = new Bitmap(BlockData.Resources.b12),
        BlockBasicYellow = new Bitmap(BlockData.Resources.b13),
        BlockBasicGreen = new Bitmap(BlockData.Resources.b14),
        BlockBasicLightBlue = new Bitmap(BlockData.Resources.b15),
        BlockBasicBlack = new Bitmap(BlockData.Resources.b182),

        //Brick Pack
        BlockBrickSaturatedBrown = new Bitmap(BlockData.Resources.b16),
        BlockBrickDarkGreen = new Bitmap(BlockData.Resources.b17),
        BlockBrickPurple = new Bitmap(BlockData.Resources.b18),
        BlockBrickLightGreen = new Bitmap(BlockData.Resources.b19),
        BlockBrickRed = new Bitmap(BlockData.Resources.b20),
        BlockBrickPaleBrown = new Bitmap(BlockData.Resources.b21),

        //Special Blocks Pack
        BlockSpecial1 = new Bitmap(BlockData.Resources.b22),
        BlockSpecial2 = new Bitmap(BlockData.Resources.b32),
        BlockSpecialNormalBlack = new Bitmap(BlockData.Resources.b33),
        BlockSpecialFullyBlack = new Bitmap(BlockData.Resources.b44),

        //Doors Pack
        BlockDoorRed = new Bitmap(BlockData.Resources.b23),
        BlockDoorGreen = new Bitmap(BlockData.Resources.b24),
        BlockDoorBlue = new Bitmap(BlockData.Resources.b25),
        BlockDoorCoinDoor = new Bitmap(BlockData.Resources.b43),
        BlockDoorTimedDoor = new Bitmap(BlockData.Resources.b156),
        BlockDoorPurpleSwitchable = new Bitmap(BlockData.Resources.b184),

        //Gates Pack
        BlockGateRed = new Bitmap(BlockData.Resources.b26),
        BlockGateGreen = new Bitmap(BlockData.Resources.b27),
        BlockGateBlue = new Bitmap(BlockData.Resources.b28),
        BlockGateTimedGate = new Bitmap(BlockData.Resources.b157),
        BlockGateCoinGate = new Bitmap(BlockData.Resources.b165),
        //BlockGatePurpleSwitchable id=185

        //Metal Pack
        BlockMetalWhite = new Bitmap(BlockData.Resources.b29),
        BlockMetalRed = new Bitmap(BlockData.Resources.b30),
        BlockMetalYellow = new Bitmap(BlockData.Resources.b31),

        //Grass Pack
        BlockGrass1 = new Bitmap(BlockData.Resources.b34),
        BlockGrass2 = new Bitmap(BlockData.Resources.b35),
        BlockGrass3 = new Bitmap(BlockData.Resources.b36),

        //Name = new Bitmap(BlockData.Resources.b[block-id]),
    }
}
