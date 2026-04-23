using UnityEngine;
using UnityEngine.Events;

public class colideur : MonoBehaviour
{
    public UnityEvent m_OncollisionEnter;
    public UnityEvent m_OncollisionStay;
    public UnityEvent m_OncollisionExit;

    public void OnCollisionEnter(Collision collision)
    {
        m_OncollisionEnter.Invoke();
    }

    public void OncollisionsStay (Collision collision)
    {
        m_OncollisionStay.Invoke();
    }

    public void OncollisionsExit(Collision collision)
    {
        Debug.Log("test");
        m_OncollisionExit.Invoke();
    }
}
