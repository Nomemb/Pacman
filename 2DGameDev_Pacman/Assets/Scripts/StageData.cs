using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageData : ScriptableObject
    // ScriptableObject : 공유 데이터를 저장할 수 있는 클래스 ( 게임에 사용되는 데이터를 저장해두고 게임 중간에 불러오기 가능) -> 아이템/ 스킬 데이터 등등 ... 게임 도중 데이터 변경 가능하다.
{
    [SerializeField]
    private Vector2 limitMin;
    [SerializeField]
    private Vector2 limitMax;

    public Vector2 LimitMin => limitMin;
    public Vector2 LimitMax => limitMax;


}
