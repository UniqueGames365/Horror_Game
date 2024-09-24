using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class myPlayerController : MonoBehaviour
{
    public float playerReach = 5f;
    Intaractable currentNtractable;

    [SerializeField] private float health = 50;
    [SerializeField] private Image helthBar;

    private FirstPersonController firstPersonController;

    public static myPlayerController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initialize health bar fill based on initial health
        helthBar.fillAmount = health / 100;
    }

    void Update()
    {
        CheckIntacrion();

        // Trigger interaction on 'F' key press if an interactable is in range
        if (Input.GetKeyDown(KeyCode.F) && currentNtractable != null)
        {
            currentNtractable.Interact();
        }

        // Clamp health to ensure it stays between 0 and 100
        health = Mathf.Clamp(health, 0, 100);
        helthBar.fillAmount = health / 100;  // Update health bar fill based on clamped health
    }

    void CheckIntacrion()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out hit, playerReach))
        {
            if (hit.collider.tag == "Intractable")
            {
                Intaractable newInteractable = hit.collider.GetComponent<Intaractable>();

                if (currentNtractable && newInteractable != currentNtractable)
                {
                    currentNtractable.DisableOutline();
                }

                if (newInteractable.enabled)
                {
                    setNewCurrentIntactable(newInteractable);
                }
                else
                {
                    disableCurrentIntractable();
                }
            }
            else
            {
                disableCurrentIntractable();
            }
        }
        else
        {
            disableCurrentIntractable();
        }
    }

    private void setNewCurrentIntactable(Intaractable newInteractable)
    {
        currentNtractable = newInteractable;
        currentNtractable.EnableOutline();
        Hud_controller.instance.enebleIntraction(currentNtractable.message);
    }

    private void disableCurrentIntractable()
    {
        Hud_controller.instance.disableIntraction();
        if (currentNtractable)
        {
            currentNtractable.DisableOutline();
            currentNtractable = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chemicalArea"))
        {
            // Set health to 0 and clamp
            health = 0;
            health = Mathf.Clamp(health, 0, 100);  // Ensures health doesn't go below 0
            helthBar.fillAmount = health / 100;
        }
    }

    public void getHelathPack()
    {
        // Increase health by 50 and clamp
        health += 50;
        health = Mathf.Clamp(health, 0, 100);  // Ensures health doesn't exceed 100
        helthBar.fillAmount = health / 100;    // Update health bar
        Debug.Log(health);
    }
}
