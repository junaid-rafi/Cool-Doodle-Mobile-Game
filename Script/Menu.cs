using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI title, score, highscore;
    public Button play, music, sound;
    public bool Music, Audio;
    public MusicManager MusicManage;
    public Image musicButtonImage, soundButtonImage;
    // Start is called before the first frame update
    public void ChangeMenu(bool x){
        title.gameObject.SetActive(x);
        score.gameObject.SetActive(!x);
        highscore.gameObject.SetActive(!x);
        play.gameObject.SetActive(x);
        music.gameObject.SetActive(x);
        sound.gameObject.SetActive(x);
    }

    public void ChangeAudio(){
        Audio = !Audio;
        MusicManage.AsDie.mute = Audio;
        MusicManage.AsJump.mute = Audio;
        ChangeButtonColor(soundButtonImage, Audio);

    }
    public void ChangeMusic(){
        Music = !Music;
        MusicManage.AsMusic.mute = Music;
        ChangeButtonColor(musicButtonImage, Music);
    }


        // Method to change the button color
    private void ChangeButtonColor(Image buttonImage, bool isMuted)
    {
        Color newColor = isMuted ? Color.red : new Color();
        if (!isMuted)
        {
            ColorUtility.TryParseHtmlString("#14AFDB", out newColor);
        }
        buttonImage.color = newColor;
    }
}
