using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    private bool isplaying= false;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void footStepController(float _speed)
    {
        if (_speed != 0 && !isplaying)
        {
            _ = startFootStepplayer();
        }
        if (_speed == 0 && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
    public async Task startFootStepplayer()
    {

        Debug.Log("hgf");
        isplaying = true;
        await FootStepPlayer();
        isplaying = false;

    }

    private async Task<bool> FootStepPlayer()
    {
        Debug.Log("uheduh");
        audioSource.Play();
        while (audioSource.isPlaying)
        {
            await Task.Yield();
        }
        return true;

    }

}
