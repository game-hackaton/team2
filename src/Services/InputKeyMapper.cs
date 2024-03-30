using thegame.Models;

namespace thegame.Services
{
    public static class InputKeyMapper
    {
        public static VectorDto Map(int key)
        {
            switch (key)
            {
                case 37:
                    return new VectorDto { X = -1, Y = 0 };
                case 38:
                    return new VectorDto { X = 0, Y = -1 };
                case 39:
                    return new VectorDto { X = 1, Y = 0 };
                case 40:
                    return new VectorDto { X = 0, Y = 1 };
                default:
                    return new VectorDto { X = 0, Y = 0 };
            }
        }
    }
}
