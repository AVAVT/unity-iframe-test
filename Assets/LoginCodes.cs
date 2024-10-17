using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class LoginCodes : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [DllImport("__Internal")]
    private static extern void Hello();

    void Start()
    {
        Hello();
    }

    public void ReceiveBrowserMessage(string message)
    {
        text.text = $"Message Received is:\n{message}";
    }
}
