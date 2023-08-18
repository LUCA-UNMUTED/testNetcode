using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using TMPro;
using Unity.Collections;

public class PlayerSettings : NetworkBehaviour
{
    public MeshRenderer meshRenderer;
    [SerializeField] private TextMeshProUGUI playerName;
    private NetworkVariable<FixedString128Bytes> networkPlayerName = new("Player: 0", NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Server);

    public Color PlayerColor;
    public List<Color> colors = new();

    public override void OnNetworkSpawn()
    {
        PlayerColor = colors[(int)OwnerClientId % colors.Count];
        meshRenderer.material.color = PlayerColor;
        networkPlayerName.Value = "Player:" + (OwnerClientId + 1);
        playerName.text = networkPlayerName.Value.ToString();
        gameObject.name = networkPlayerName.Value.ToString(); // in Unity editor more clearly
    }
}
