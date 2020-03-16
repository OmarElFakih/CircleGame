using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingMarker : MonoBehaviour
{
    [SerializeField] private Image _ringImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_ringImage != null)
        {
            float _rotationAmount = _ringImage.fillAmount * -360;

            Vector3 _rotation = new Vector3(0f, 0f, _rotationAmount);

            transform.rotation = Quaternion.Euler(_rotation);
        }
    }
}
