using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [Tooltip("Life of player")]
    [SerializeField] int life = 3;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && life > 0) {
            life--;
            Destroy(other.gameObject);
        }
        else if (other.tag == triggeringTag && enabled && life < 1) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
