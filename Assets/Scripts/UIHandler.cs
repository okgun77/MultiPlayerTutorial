using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField createRoomTF;
    [SerializeField] private TMP_InputField joinRoomTF;


    public void OnClickCreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoomTF.text, new RoomOptions { MaxPlayers = 4}, null);
    }

    public void OnClickJoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomTF.text, null);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Room Joined Success");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("RoomFailed "+returnCode+" Message "+message);
    }

}
