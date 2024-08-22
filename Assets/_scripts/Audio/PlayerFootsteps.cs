using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

enum groundType
{
    BWood,
    BMud,
    BMetal
}
public class PlayerFootsteps : MonoBehaviour
{
    private bool isplaying= false;
    private bool isWool=false;
    private bool isMud= false;
    private bool isMetal=false;    
    AudioSource audioSource;
    [SerializeField] private AudioClip WoodClip;
    [SerializeField] private AudioClip MudClip;
    [SerializeField] private AudioClip MetalClip;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, out hit))
        {
  
            if (hit.collider.tag == groundType.BWood.ToString())
            {
                isWool= true;
                isMud= false;
                isMetal= false;
            }
            else if(hit.collider.tag == groundType.BMud.ToString())
            {
                isMud= true;
                isMetal= false;
                isWool = false;
            }
            else if(hit.collider.tag == groundType.BMetal.ToString())
            {
                isMetal= true;
                isWool= false;
                isWool =false;
            }
        }
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
        isplaying = true;
        await FootStepPlayer();
        isplaying = false;
    }

    private async Task<bool> FootStepPlayer()
    {
        if(isWool)
        {
           audioSource.clip= WoodClip;
        }
        else if (isMud)
        {
            audioSource.clip= MudClip;
        }
        else if (isMetal)
        {
            audioSource.clip= MetalClip;
        }
        else
        {
            audioSource.clip = WoodClip;
        }
        audioSource.Play();
        while (audioSource.isPlaying)
        {
            await Task.Yield();
        }
        return true;

    }

}
