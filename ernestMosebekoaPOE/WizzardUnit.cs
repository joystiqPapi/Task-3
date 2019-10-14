namespace ernestMosebekoaPOE
{
    public class WizzardUnit: Unit
    {
         //constructor
        public WizzardUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string team, char unitSymbol, bool isAttacking, string unitName) : base(xPosition, yPosition, 100, 1, 5, attackRange, "Wizard", 'W', false, unitName)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.unitName = unitName;





        }

        public int XPosition { get => base.xPosition; set => base.xPosition = value; }
        public int YPosition { get => base.yPosition; set => base.yPosition = value; }
        public int Health { get => base.health; set => base.health = value; }
        public int MaxHealth { get => base.maxHealth; }
        public int Speed { get => base.speed; set => base.speed = value; }
        public int Attack { get => base.attack; set => base.attack = value; }
        public int AttackRange { get => base.attackRange; set => base.attackRange = value; }
        public string Team { get => base.team; set => base.team = value; }
        public char UnitSymbol { get => base.unitSymbol; set => base.unitSymbol = value; }
        public bool IsAttacking { get => base.isAttacking; set => base.isAttacking = value; }

        public override void move(int xPosition, int yPosition)
        {//run away whwen Hp gegts to 50
         
            
        }

        public override void combat(int enemyAttackStrength)
        {
            
        }

        public override bool withinRange(int distance)
        {
            return false;
        }

        public override int[] returnPosition()
        {
            return null;
        }

        public override bool isDead()
        {
            bool unitDead = false;
            if(health <= 0)
            {
                unitDead = true;
            }
            return unitDead;
           
        }

        public override string toString()
        {
            throw new System.NotImplementedException();
        }

        public override int returnAttackStrength()
        {
            throw new System.NotImplementedException();
        }

        public override char returnSymbol()
        {
            throw new System.NotImplementedException();
        }

        public override string returnUnitName()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            string sentence = "I am Wizard";

            return sentence;
        }

        public bool attack()
        {
            bool attack = false;
            int[,] WizzardPosition;

            for (int k = 0; k < 20; k++)
            {
                for (int y = 0; y < 20; y++)
                {
                    WizzardPosition = new int[YPosition, XPosition];

                }
            }
            return attack;
        }
    }
}