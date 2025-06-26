using UnityEngine;
using UnityEngine.UI;

public class DriveSimulatorScreen : MonoBehaviour
{
    [Header("Drive Controls")]
    public Button forwardButton;
    public Button reverseButton;
    public Button brakeButton;

    [Header("Fork Controls")]
    public Button forkUpButton;
    public Button forkDownButton;
    public Button forkTiltButton;

    [Header("Camera")]
    public Button cameraSwitchButton;
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    [Header("Forklift Model")]
    public GameObject forkliftModel;

    private bool useFirstPerson = true;

    void Start()
    {
        if (forwardButton != null)
            forwardButton.onClick.AddListener(MoveForward);
        if (reverseButton != null)
            reverseButton.onClick.AddListener(MoveBackward);
        if (brakeButton != null)
            brakeButton.onClick.AddListener(StopMovement);

        if (forkUpButton != null)
            forkUpButton.onClick.AddListener(MoveForkUp);
        if (forkDownButton != null)
            forkDownButton.onClick.AddListener(MoveForkDown);
        if (forkTiltButton != null)
            forkTiltButton.onClick.AddListener(TiltFork);

        if (cameraSwitchButton != null)
            cameraSwitchButton.onClick.AddListener(SwitchCamera);

        SetCameraView(useFirstPerson);
    }

    void MoveForward()
    {
        // Implement forward movement logic
    }

    void MoveBackward()
    {
        // Implement backward movement logic
    }

    void StopMovement()
    {
        // Implement brake logic
    }

    void MoveForkUp()
    {
        // Implement fork up logic
    }

    void MoveForkDown()
    {
        // Implement fork down logic
    }

    void TiltFork()
    {
        // Implement fork tilt logic
    }

    void SwitchCamera()
    {
        useFirstPerson = !useFirstPerson;
        SetCameraView(useFirstPerson);
    }

    void SetCameraView(bool firstPerson)
    {
        if (firstPersonCamera != null)
            firstPersonCamera.enabled = firstPerson;
        if (thirdPersonCamera != null)
            thirdPersonCamera.enabled = !firstPerson;
    }
}

