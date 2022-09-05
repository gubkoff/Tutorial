using UnityEngine;

namespace ScriptableObjectTutorial {
    [CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
    public class Card : ScriptableObject {
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        
        [SerializeField] private Sprite _characterSprite;
        
        [SerializeField] private int _manaCost;
        [SerializeField] private int _attack;
        [SerializeField] private int _health;

        public string Name => _name;
        public string Description => _description;
        
        public Sprite CharacterSprite => _characterSprite;
        
        public int ManaCost => _manaCost;
        public int Attack => _attack;
        public int Health => _health;

        public void Print() {
            Debug.Log($"{_name} : {_description} | The card costs: {_manaCost}");
        }
    }
}