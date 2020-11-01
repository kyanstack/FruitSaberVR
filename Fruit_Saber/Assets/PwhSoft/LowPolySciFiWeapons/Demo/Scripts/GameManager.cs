using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GlowingSwords.Scripts
{
    public class GameManager : MonoBehaviour
    {
        private List<GlowingSword> _lightSabers;
        
        // Start is called before the first frame update
        private void Start()
        {
            _lightSabers = gameObject.FindChildrenByType<GlowingSword>();
        }

        public void ToggleLightSabers()
        {
            _lightSabers?.ForEach(s=>s.ToggleActive());
        }
    }
}
