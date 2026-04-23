
using UnityEngine;
using UnityEngine.Events;

public class TriggerReactor : MonoBehaviour
{

    public UnityEvent m_OnTriggerEnter;
    public UnityEvent m_OnTriggerStay;
    public UnityEvent m_OnTriggerExit;

    public void OnCollisionEnter(Collision collision)
    {
        m_OnTriggerEnter.Invoke();
 
    }

    public void OnCollisionStay(Collision collision)
    {
        m_OnTriggerStay.Invoke();
    }

    public void OnCollisionExit(Collision collision)
    {
        m_OnTriggerExit.Invoke();
    }
}
