using MinotaurLabyrinth;

namespace MinotaurLabyrinthTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void PitRoomTest()
        {
            Pit pitRoom = new Pit();
            Hero hero = new Hero();
            Map map = new Map(1,1);

            pitRoom.Activate(hero, map);
            Assert.AreEqual(pitRoom.IsActive, false);
            Assert.Equals(hero.IsAlive, true);

            hero.HasSword = true;
            pitRoom.Activate(hero, map);
            Assert.Equals(hero.IsAlive, false);
        }
    }
}
