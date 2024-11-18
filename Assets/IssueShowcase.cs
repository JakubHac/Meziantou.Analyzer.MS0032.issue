using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class IssueShowcase : MonoBehaviour
{
    public async void Start()
    {
        //this shows a warning
        await Task.Run(() =>Task.CompletedTask).ConfigureAwait(false); 
        //this doesn't
        await UniTask.NextFrame();
        //but it should
        await UniTask.NextFrame(destroyCancellationToken);
    }
}
