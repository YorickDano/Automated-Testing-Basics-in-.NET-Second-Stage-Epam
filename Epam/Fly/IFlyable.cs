namespace Epam.Fly
{
    interface IFlyable
    {
        public void FlyTo(Coordinate next);
        public int GetFlyTime(Coordinate coordinate);
    }
}
