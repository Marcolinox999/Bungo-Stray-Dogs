using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameMenuManager : MonoBehaviour
{
    [SerializeField] private InputField m_inputField;
    [SerializeField] private Button m_button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        if (m_inputField.text != "")
        {
            SceneManager.LoadScene(2);
        }
    }

    public void OntextSubmitt()
    {
        NameHolder.instance.name = m_inputField.text;
    }
}
