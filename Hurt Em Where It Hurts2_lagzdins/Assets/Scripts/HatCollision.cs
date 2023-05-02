using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatCollision : MonoBehaviour
{
   public Sprite Original;
   public Sprite Tophat;
   public Sprite Cap;
   public Sprite Furrhat;
   public Sprite Admiral;
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name=="Tophat"){
			this.gameObject.GetComponent<Image>().sprite=Tophat;
		}
    if(collision.gameObject.name=="Furrhat"){
			this.gameObject.GetComponent<Image>().sprite=Furrhat;
		}
    if(collision.gameObject.name=="Cap"){
      	this.gameObject.GetComponent<Image>().sprite=Cap;
		}
    if(collision.gameObject.name=="Admiral"){
			this.gameObject.GetComponent<Image>().sprite=Admiral;
		}
     if(collision.gameObject.name=="Remover"){
			this.gameObject.GetComponent<Image>().sprite=Original;
		}
	}
}
