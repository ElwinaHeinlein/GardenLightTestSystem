using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMover : MonoBehaviour
{
    
    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 0.1f;

    
    public InputActionReference moveAction;
    public InputActionReference lookAction;

    public PlayerInput pi;

    private void OnEnable()
    {
        if(moveAction!=null){moveAction.action.Enable();}
        if(lookAction!=null){lookAction.action.Enable();}
    }

    private void OnDisable()
    {
        if(moveAction!=null){moveAction.action.Disable();}
        if(lookAction!=null){lookAction.action.Disable();}
        
    }

    private void Start()
    {
        pi = GetComponent<PlayerInput>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 moveInput=Vector2.zero;
        Vector2 mouseInput=Vector2.zero;
        if(moveAction!=null){
            moveInput = moveAction.action.ReadValue<Vector2>();
            mouseInput = lookAction.action.ReadValue<Vector2>();
        }
        
        float spin = mouseInput.x * mouseSensitivity;
        transform.Rotate(Vector3.up * spin);

        
        
        Vector3 localMove = new Vector3(moveInput.x, 0, moveInput.y);

        
        transform.Translate(localMove * moveSpeed * Time.deltaTime);
    }
}