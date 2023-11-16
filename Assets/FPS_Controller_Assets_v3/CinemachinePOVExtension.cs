using UnityEngine;
using Cinemachine;


public class CinemachinePOVExtension : CinemachineExtension
{
    [SerializeField]
    private float horizontalSpeed = 10f;
    [SerializeField]
    private float verticalSpeed = 10f;
    [SerializeField]
    private float clampAngle = 80f;

    private InputManager inputManager;
    private Vector3 startingRotation;

    private Vector3 _overrideRotation;

    public Vector3 OverrideRotation
    {
        get { return _overrideRotation; }
        set { 
            _overrideRotation = value;
            overrideCamPos = true;
        }
    }

    public bool lockCam = false;

    private bool overrideCamPos = false;

    protected override void Awake()
    {
        inputManager = InputManager.Instance;

        //startingRotation = transform.localRotation.eulerAngles;

        base.Awake();
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
#if UNITY_EDITOR
        if(!Application.isPlaying) { return; }
#endif
        if (vcam.Follow)
        {
            if(stage == CinemachineCore.Stage.Aim)
            {
                if (startingRotation == null) startingRotation = transform.localRotation.eulerAngles;
                if (overrideCamPos)
                {
                    Debug.Log("Reseting Cam Pos");
                    //startingRotation = new Vector3(90,0,0);
                    startingRotation = this._overrideRotation;
                    state.RawOrientation = Quaternion.Euler(startingRotation);
                    overrideCamPos = false;
                    return;
                }
                Vector2 deltaInput = inputManager.GetMouseDelta();
                if (lockCam) deltaInput = Vector2.zero;
                startingRotation.x += deltaInput.x * verticalSpeed * Time.deltaTime;
                startingRotation.y += deltaInput.y * horizontalSpeed * Time.deltaTime;

                startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0f);
            }
        }
    }
}
