///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentAI.Contract.Vision.Face
{
    public class FaceDetectResult
    {
        public FaceDetectResult()
        {

        }

        public int ret { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public int image_width { get; set; }
            public int image_height { get; set; }
            public List<Face_listItem> face_list { get; set; }
        }

        public class Face_listItem
        {
            public string face_id { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int gender { get; set; }
            public int age { get; set; }
            public int expression { get; set; }
            public int beauty { get; set; }
            public int glass { get; set; }
            public int pitch { get; set; }
            public int yaw { get; set; }
            public int roll { get; set; }
            public Face_shape face_shape { get; set; }
        }

        public class Face_shape
        {
            public List<Face_profileItem> face_profile { get; set; }
            public List<Left_eyeItem> left_eye { get; set; }
            public List<Right_eyeItem> right_eye { get; set; }
            public List<Left_eyebrowItem> left_eyebrow { get; set; }
            public List<Right_eyebrowItem> right_eyebrow { get; set; }
            public List<MouthItem> mouth { get; set; }
            public List<NoseItem> nose { get; set; }
        }

        public class Face_profileItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Left_eyeItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Right_eyeItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Left_eyebrowItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Right_eyebrowItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class MouthItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class NoseItem
        {
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
