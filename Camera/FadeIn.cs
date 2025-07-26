using System.Collections;
using UnityEngine;

public class FadeIn : ScreenEffect
{
    private float time;
    public override void DoEffect(float Time)
    {
        time = Time;
        StartCoroutine(nameof(Effect));
    }
    private IEnumerator Effect()
    {
        var col = img.color;
        while (col.a < 1)
        {
            col.a += Time.deltaTime/time;
            img.color = col;
            yield return null;
        }
        End();
    }
}
