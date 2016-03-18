using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake_4._0.Game;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class Test
    {
        // Player Class Test
        [TestMethod]
        public void TestPlayerConstructor()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            Assert.IsNotNull(World.Instance.Player);
            Assert.AreEqual(World.Instance.Player.LocationX, 50);
            Assert.AreEqual(World.Instance.Player.LocationY, 50);
            Assert.AreEqual(World.Instance.Player.MaxHealth, 5);
            Assert.AreEqual(World.Instance.Player.Health, 5);
            Assert.AreEqual(World.Instance.Player.Money, 0);
            Assert.AreEqual(World.Instance.Player.HBSize, 40);
            Assert.AreEqual(World.Instance.Player.Multiplier, 1);
            Assert.IsNotNull(World.Instance.Player.PlayerHitbox);
            Assert.IsNotNull(World.Instance.Player.GoldPickUpHitbox);
        }

        [TestMethod]
        public void TestHitboxes()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            Assert.AreEqual(World.Instance.Player.PlayerHitbox.X, World.Instance.Player.LocationX - 10);
            Assert.AreEqual(World.Instance.Player.PlayerHitbox.Y, World.Instance.Player.LocationY - 10);
            Assert.AreEqual(World.Instance.Player.PlayerHitbox.Width, 20);
            Assert.AreEqual(World.Instance.Player.PlayerHitbox.Height, 20);
        }

        [TestMethod]
        public void TestMoveLeft()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            World.Instance.Player.Left = true;
            World.Instance.Player.Move(WSize);
            Assert.AreEqual(World.Instance.Player.LocationX, 50 - World.Instance.Player.MoveSpeed);

        }

        [TestMethod]
        public void TestMoveRight()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            World.Instance.Player.Right = true;
            World.Instance.Player.Move(WSize);
            Assert.AreEqual(World.Instance.Player.LocationX, 50 + World.Instance.Player.MoveSpeed);

        }

        [TestMethod]
        public void TestMoveUp()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            World.Instance.Player.Up = true;
            World.Instance.Player.Move(WSize);
            Assert.AreEqual(World.Instance.Player.LocationY, 50 - World.Instance.Player.MoveSpeed);

        }

        [TestMethod]
        public void TestMoveDown()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            World.Instance.Player.Down = true;
            World.Instance.Player.Move(WSize);
            Assert.AreEqual(World.Instance.Player.LocationY, 50 + World.Instance.Player.MoveSpeed);

        }

        [TestMethod]
        public void TestDamageCheck()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            bool result = World.Instance.Player.DamageCheck(3);
            Assert.IsFalse(result);
            Assert.AreEqual(World.Instance.Player.Health, 2);

        }

        [TestMethod]
        public void TestDeath()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            bool result = World.Instance.Player.DamageCheck(10);
            Assert.IsTrue(result);
            Assert.AreEqual(World.Instance.Player.Health, -5);

        }

        [TestMethod]
        public void TestMaxHealth()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);
            World.Instance.Player.MaxHealth = 24;

            bool result = World.Instance.Player.DamageCheck(-10);
            Assert.IsFalse(result);
            Assert.AreEqual(World.Instance.Player.Health, 15);

            result = World.Instance.Player.DamageCheck(-10);
            Assert.IsFalse(result);
            Assert.AreEqual(World.Instance.Player.Health, 24);
        }

        [TestMethod]
        public void TestCheckHitbox()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);

            Enemy E = new Enemy(new Point(55, 55), "Normal");
            bool result = World.Instance.Player.CheckHitbox(E);
            Assert.IsTrue(result);

            Enemy E2 = new Enemy(new Point(70, 70), "Normal");
            result = World.Instance.Player.CheckHitbox(E2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckGoldPickUp()
        {
            Size WSize = new Size(100, 100);
            World.Instance.Create_Player(WSize);

            Gold G = new Gold(new Point(55, 55));
            bool result = World.Instance.Player.CheckGoldPickUp(G);
            Assert.IsTrue(result);

            Gold G2 = new Gold(new Point(75, 75));
            result = World.Instance.Player.CheckGoldPickUp(G2);
            Assert.IsFalse(result);
        }

        // Enemy Class Test
        [TestMethod]
        public void TestEnemyConstructor()
        {
            Enemy E = new Enemy(new Point(5, 5), "Normal");
            Assert.AreEqual(E.LocationX, 5);
            Assert.AreEqual(E.LocationY, 5);
            Assert.AreEqual(E.Health, 2);
            Assert.AreEqual(E.Damage, 3);
            Assert.AreEqual(E.Type, "Normal");
            Assert.IsNotNull(E.Hitbox);

            E = new Enemy(new Point(25, 25), "Medic");
            Assert.AreEqual(E.LocationX, 25);
            Assert.AreEqual(E.LocationY, 25);
            Assert.AreEqual(E.Health, 5);
            Assert.AreEqual(E.Damage, -10);
            Assert.AreEqual(E.Type, "Medic");
            Assert.IsNotNull(E.Hitbox);
        }

        [TestMethod]
        public void TestEnemyMove()
        {
            Enemy E = new Enemy(new Point(5, 5), "Normal");
            E.Move(25, 25);
            Assert.AreEqual(E.LocationX, 7);
            Assert.AreEqual(E.LocationY, 7);

            E = new Enemy(new Point(5, 5), "Normal");
            E.Move(25, 5);
            Assert.AreEqual(E.LocationX, 8);
            Assert.AreEqual(E.LocationY, 5);

            E = new Enemy(new Point(5, 5), "Normal");
            E.Move(25, 5);
            Assert.AreEqual(E.LocationX, 8);
            Assert.AreEqual(E.LocationY, 5);

            E = new Enemy(new Point(5, 5), "Normal");
            E.Move(50, 25);
            Assert.AreEqual(E.LocationX, 7);
            Assert.AreEqual(E.LocationY, 6);
        }

        [TestMethod]
        public void TestEnemyDamageCheck()
        {
            Enemy E = new Enemy(new Point(5, 5), "Normal");
            bool result = E.DamageCheck(1);
            Assert.IsFalse(result);
            Assert.AreEqual(E.Health, 1);

            result = E.DamageCheck(2);
            Assert.IsTrue(result);
            Assert.AreEqual(E.Health, -1);

            E = new Enemy(new Point(5, 5), "Medic");
            result = E.DamageCheck(2);
            Assert.IsFalse(result);
            Assert.AreEqual(E.Health, 3);

            result = E.DamageCheck(3);
            Assert.IsTrue(result);
            Assert.AreEqual(E.Health, 0);
        }

        [TestMethod]
        public void TestEnemyHitboxes()
        {
            Enemy E = new Enemy(new Point(50, 50), "Normal");
            Assert.AreEqual(E.Hitbox.X, E.LocationX - 10);
            Assert.AreEqual(E.Hitbox.Y, E.LocationY - 10);
            Assert.AreEqual(E.Hitbox.Width, 20);
            Assert.AreEqual(E.Hitbox.Height, 20);
        }
    }
}
