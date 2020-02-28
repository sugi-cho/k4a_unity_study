using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.Azure.Kinect.Sensor;

//https://tks-yoshinaga.hatenablog.com/entry/azurekinect-5
public class OpenKinect : MonoBehaviour
{

    Device kinect;
    // Start is called before the first frame update
    void Start()
    {
        kinect = Device.Open(0);
        kinect.StartCameras(new DeviceConfiguration
        {
            ColorFormat = ImageFormat.ColorBGRA32,
            ColorResolution = ColorResolution.R720p,
            DepthMode = DepthMode.NFOV_2x2Binned,
            SynchronizedImagesOnly = true,
            CameraFPS = FPS.FPS30,
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        kinect.StopCameras();
    }
}
