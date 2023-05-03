using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatCollision : MonoBehaviour
{
	public string gender;
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
   public static Sprite current;
	private void OnCollisionEnter2D(Collision2D collision){
    if(gender=="boy"){
	if(collision.gameObject.name=="Tophat"){
			this.gameObject.GetComponent<Image>().sprite=boyTophat;
			current=boyTophat;
		}
    if(collision.gameObject.name=="Furrhat"){
			this.gameObject.GetComponent<Image>().sprite=boyFurrhat;
			current=boyFurrhat;
		}
    if(collision.gameObject.name=="Cap"){
      	this.gameObject.GetComponent<Image>().sprite=boyCap;
		current=boyCap;
		}
    if(collision.gameObject.name=="Admiral"){
			this.gameObject.GetComponent<Image>().sprite=boyAdmiral;
			current=boyAdmiral;
		}
     if(collision.gameObject.name=="Remover"){
			this.gameObject.GetComponent<Image>().sprite=boy;
			current=boy;
		}
    }else{
		if(collision.gameObject.name=="Tophat"){
			this.gameObject.GetComponent<Image>().sprite=girlTophat;
			current=girlTophat;
		}
    if(collision.gameObject.name=="Furrhat"){
			this.gameObject.GetComponent<Image>().sprite=girlFurrhat;
			current=girlFurrhat;
		}
    if(collision.gameObject.name=="Cap"){
      	this.gameObject.GetComponent<Image>().sprite=girlCap;
		current=girlCap;
		}
    if(collision.gameObject.name=="Admiral"){
			this.gameObject.GetComponent<Image>().sprite=girlAdmiral;
			current=girlAdmiral;
		}
     if(collision.gameObject.name=="Remover"){
			this.gameObject.GetComponent<Image>().sprite=girl;
			current=girl;
		}
    }
	}
}
