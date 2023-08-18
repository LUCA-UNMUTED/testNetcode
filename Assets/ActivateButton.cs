using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ActivateButton : NetworkBehaviour
{

    [SerializeField] private Color active;
    [SerializeField] private Color neutral;

    private NetworkVariable<bool> isActive = new(false, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Server);
    private MeshRenderer _mesh;
    // Start is called before the first frame update
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isActive.Value)
        {
            _mesh.material.SetColor("_BaseColor", active);
        }
        else
        {
            _mesh.material.SetColor("_BaseColor", neutral);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        AlterActiveServerRpc();
    }

    [ServerRpc(RequireOwnership = false)]
    private void AlterActiveServerRpc()
    {
        isActive.Value = !isActive.Value;

    }
}
