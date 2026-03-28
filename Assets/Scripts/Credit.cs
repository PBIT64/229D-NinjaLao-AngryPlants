using UnityEngine;

public class Credit : MonoBehaviour
{
    GameObject CreditGui;
    private void Start()
    {
        CreditGui = transform.parent.parent.Find("CreditGui").gameObject;
    }

    public void CreditToggle()
    {
        CreditGui.SetActive(!CreditGui.activeSelf);
    }
}
