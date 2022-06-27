using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using UnityEngine.SceneManagement;


public class bird : MonoBehaviour
{
    public  Text score1;
    public GameObject play;
    public float speed = 1.5f;
    public float speedd = 1.5f;
    Vector2 dir = Vector2.up;
    bool isDead;
    bool tr;
    float max = 1f;
    float min = -1f;
    float dis=2f;
    int score=0;

    public GameObject Replay;
    public GameObject Ok;
    public void replay ()
    {
        SceneManager.LoadScene(1);
    }
    public void change()
    {
        SceneManager.LoadScene(0);

    }


     void OnCollisionEnter2D(Collision2D cal)
    {
        isDead = true;
        GetComponent<Rigidbody2D>().velocity= Vector2.zero;
        GetComponent<Animator>().SetBool("isdead", true);
        Ok.SetActive(true);
        Replay.SetActive(true);

      

            }
    void OnTriggerExit2D (Collider2D cc)
    {
        if (cc.tag == "obs")
        {
            float obsY = Random.Range(min, max);
            Debug.Log(obsY);
            Vector3 spaw = new Vector3(transform.position.x + dis, obsY, 0);
            cc.gameObject.transform.position = spaw;

        }
        if (cc.tag=="scr")
        {
            score += 10;
            score1.text = score.ToString();
        }
       
    
    }
    public void Freez ()
    {
       tr = true;
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        GetComponent<Rigidbody2D>().velocity = speed * Time.timeScale * Vector2.right;


    }

    // Update is called once per frame
    void Update()
    {


      

        if (tr == true)
        {
            Destroy(play);
        }

        if ((Input.GetButtonDown("Jump")) && (!(isDead)))
        {
            
      
            GetComponent<Rigidbody2D>().velocity =(dir* speed) + (Vector2.right * speedd * Time.deltaTime);
            
        } 
    }
}
