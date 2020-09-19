namespace RPGCombatKata {
    public class Character {
        private int _health = 1000;
        private int Health {
            get => _health;
            set {
                _health = value;
                if (_health < 0) _health = 0;
                IsAlive = _health > 0;
            }
        }
        public int Level { get; set; } = 1;
        private bool IsAlive { get; set; } = true;

        public void DamageOtherCharacter(Character character) {
            character.Health -= 100;
        }

        public void Heal(int amount) {
            Health += amount;
        }
    }
}