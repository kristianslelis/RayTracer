using OpenTK.Mathematics;

class Camera
{
    public Vector3 Position { get; set; }
    public Vector3 ViewDirection { get; set; }
    public Vector3 UpDirection { get; set; }
    public Vector3 RightDirection { get; set; }
    public Vector3 TopLeft { get; set; }
    public Vector3 TopRight { get; set; }
    public Vector3 BottomLeft { get; set; }

    public Camera()
    {
        Position = new Vector3(0,0,0);
        ViewDirection = new Vector3(0,0,1);
        UpDirection = new Vector3(0,1,0);
        RightDirection = new Vector3(1,0,0);
    }
    private void ImagePlane()
    {
        TopLeft = Position + UpDirection - RightDirection;
        TopRight = Position + UpDirection + RightDirection;
        BottomLeft = Position - UpDirection - RightDirection;

    }



}