using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatCollision : MonoBehaviour
{
	public string type;
   public Sprite boy;
   public Sprite girl;
   public Sprite boyTophat;
   public Sprite girlTophat;
   public Sprite boyCap;
   public Sprite girlCap;
   public Sprite girlFurrhat;
   public Sprite boyFurrhat;
   public Sprite boyAdmiral;
   public Sprite girlAdmiral;
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name=="Tophat"){
			this.gameObject.GetComponent<Image>().sprite=boyTophat;
		}
    if(collision.gameObject.name=="Furrhat"){
			this.gameObject.GetComponent<Image>().sprite=boyFurrhat;
		}
    if(collision.gameObject.name=="Cap"){
      	this.gameObject.GetComponent<Image>().sprite=boyCap;
		}
    if(collision.gameObject.name=="Admiral"){
			this.gameObject.GetComponent<Image>().sprite=boyAdmiral;
		}
     if(collision.gameObject.name=="Remover"){
			this.gameObject.GetComponent<Image>().sprite=boy;
		}
	}
}
