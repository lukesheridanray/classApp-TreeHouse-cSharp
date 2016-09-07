namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Tower tower = new Tower();
            map map = new TreehouseDefense.map(8, 5);

            Point point = new Point(4, 2);

            bool isOnMap = map.OnMap(point);
            
            point = new Point(8, 5);
            isOnMap = map.OnMap(point);
        }
    }
}