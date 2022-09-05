using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectTutorial {
    public class CardDisplay : MonoBehaviour {
        [SerializeField] private Card _card;
        
        [SerializeField] private Text _nameText;
        [SerializeField] private Text _descriptionText;
        
        [SerializeField] private Image _characterIcon;
        
        [SerializeField] private Text _manaText;
        [SerializeField] private Text _attackText;
        [SerializeField] private Text _healthText;
        
        void Start() {
            _nameText.text = _card.Name;
            _descriptionText.text = _card.Description;
            
            _characterIcon.sprite = _card.CharacterSprite;
            
            _manaText.text = _card.ManaCost.ToString();
            _attackText.text = _card.Attack.ToString();
            _healthText.text = _card.Health.ToString();
        }
    }
}
