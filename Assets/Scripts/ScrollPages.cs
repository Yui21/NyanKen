using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
public class ScrollPages : ScrollRect
{
    //ページ数
    public int PageNumber;
    //しきい値
    public float ThresholdValue;
 
    private float beforePosition;
 
    public override void OnBeginDrag(PointerEventData data)
    {
        base.OnBeginDrag(data);
        //座標取得
        beforePosition = horizontalNormalizedPosition;
    }
 
    public override void OnEndDrag(PointerEventData data)
    {
        base.OnEndDrag(data);
        //次のページ取得
        float nextPage = CalcNextPage(beforePosition, horizontalNormalizedPosition);
        //座標設定
        horizontalNormalizedPosition = nextPage / (PageNumber - 1);
    }
 
    /// <summary>
    /// スライド量がしきい値に満たない場合は自ページ
    /// 右にスライドしたときは次ページ
    /// 左にスライドしたときは前ページを返す
    /// </summary>
    /// クリック時座標
    /// 離したときの座標
    /// 
    private float CalcNextPage(float beforPosition, float afterPosition)
    {
        //移動量（％）を求める
        float differencePosition = (afterPosition - beforPosition) * (PageNumber - 1);
        
        //移動量（％）がしきい値以下の場合、自ページを返す
        if (Mathf.Abs(differencePosition) <= ThresholdValue)
        {
            return beforPosition * (PageNumber - 1);
        }
 
        if (differencePosition > 0)
        {
            //右にスライドした時は切り上げ（次ページ）
            return Mathf.Ceil(afterPosition * (PageNumber - 1));
        }
        else
        {
            //左にスライドした時は切り捨て（前ページ）
            return Mathf.Floor(afterPosition * (PageNumber - 1));
        }
    }
}