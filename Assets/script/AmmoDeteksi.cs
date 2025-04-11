using UnityEngine;
using UnityEngine.UI;

public class AmmoDeteksi : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Use this for initialization
    void Start()
    {
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            ScoreData.score += 25;
            textScore.text = ScoreData.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            ScoreData.score -= 5;
            textScore.text = ScoreData.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }
}
