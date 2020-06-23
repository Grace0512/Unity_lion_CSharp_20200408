using UnityEngine;
using UnityEngine.EventSystems; //引用 事件系統API-拖拉介面

//實作介面後也要實作介面所有成員
public class Card : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private Vector3 pos;
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("開始拖拉了~");
        pos = transform.position;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉中..");
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("放手了~");
        transform.position = pos;
    }

    public void SkillEffect()
    {
        print("技能特效");
    }

    /*public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }*/
}
