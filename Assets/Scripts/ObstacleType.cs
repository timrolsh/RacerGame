public enum ObstacleType
{
    // BigCone and Cone are going to be the positive ObstacleTypes, if you hit these your score will go up
    BigCone = 0,
    Cone = 1,
    // everything else will be the negative ObstacleTypes, if you hit these you will die
    Barrier = 2,
    PyramidBarrier = 3,
    ShortBarrier = 4,
    WarningSign = 5
}
