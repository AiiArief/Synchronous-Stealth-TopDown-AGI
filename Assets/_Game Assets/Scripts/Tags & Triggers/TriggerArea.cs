using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera m_vcam;

    //[SerializeField] MeshRenderer[] m_roofs;

    [SerializeField] UnityEvent m_onTriggerEnterEvent;

    bool m_isPlayerHere = false;

    // bisa dipake buat hemat poly kayaknya

    private void OnTriggerStay(Collider other)
    {
        if (m_isPlayerHere)
            return;

        EntityCharacterPlayer player = other.GetComponent<EntityCharacterPlayer>();
        if (player)
        {
            m_isPlayerHere = true;

            /*if (m_roofs.Length > 0)
            {
                foreach (MeshRenderer roofChild in m_roofs)
                {
                    roofChild.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
            }*/

            if (m_vcam)
                m_vcam.gameObject.SetActive(true);

            if(m_onTriggerEnterEvent.GetPersistentEventCount() > 0)
            {
                m_onTriggerEnterEvent.Invoke();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!m_isPlayerHere)
            return;

        EntityCharacterPlayer player = other.GetComponent<EntityCharacterPlayer>();
        if (player)
        {
            m_isPlayerHere = false;
            
            //if (m_roofs.Length > 0)
            //{
            //    foreach (MeshRenderer roofChild in m_roofs)
            //    {
            //        roofChild.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            //    }
            //}

            if (m_vcam)
                m_vcam.gameObject.SetActive(false);
        }
    }
}
