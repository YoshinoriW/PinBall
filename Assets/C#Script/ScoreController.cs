using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    //得点の初期値を0に設定
    private int score = 0;
    //得点を表示するテキスト
    private GameObject scoreText;

	// Use this for initialization
	void Start () {

        //シーン中のscoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {

        //衝突した場合scoreTextに得点を表示
            this.scoreText.GetComponent<Text>().text = "得点 :" + score;

        }
    

    void OnCollisionEnter(Collision other){

        //タグによって得点を変える
        if (other.gameObject.tag == "SmallStarTag"){
            score += 1;
        }else if (other.gameObject.tag == "LargeStarTag"){
            score += 100;
        }else if (other.gameObject.tag == "SmallCloudTag") {
            score += 2000;
        }else if(other.gameObject.tag == "LargeCloudTag"){
            score += 50000;
        }
    }
}
