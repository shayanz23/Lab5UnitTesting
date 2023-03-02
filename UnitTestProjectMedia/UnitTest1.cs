using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryMedia;
using TagLib;
using System.Drawing;
using Image = System.Drawing.Image;
using System.IO;
using System.Linq;
using File = TagLib.File;

/// <summary>
/// Lab 5 Calculator Application 
/// Authors: Shayan Zahedanaraki, Daniel Chellapan
/// Date: March 1, 2023; Revision: -
/// Source:
/// EXternal Libraries: https://github.com/mono/taglib-sharp
/// </summary>
namespace UnitTestProjectMedia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScanAudioTest()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] fileTypes = { ".mp3", ".wav", ".flac", ".m4a", ".ogg" };
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                 .Where(file => fileTypes.Contains(Path.GetExtension(file)))
                                 .ToArray();
            MediaScanner.scanAudio();
            Assert.IsTrue(MediaScanner.Audios.Count > 0);

            if (files.Length != 0)
            {
                Assert.IsTrue(MediaScanner.Audios.Count > 0);
            }
            else
            {
                Assert.IsTrue(!(MediaScanner.Audios.Count > 0));
            }
        }

        [TestMethod]
        public void ScanVideoTest()
        {
            string[] fileTypes = { ".mp4", ".mkv", ".mov" };
            MediaScanner.scanVideo();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                 .Where(file => fileTypes.Contains(Path.GetExtension(file)))
                                 .ToArray();

            if (files.Length != 0)
            {
                Assert.IsTrue(MediaScanner.Videos.Count > 0);
            } else
            {
                Assert.IsTrue(!(MediaScanner.Videos.Count > 0));
            }    
        }

        [TestMethod]
        public void GetCoverArt_ShouldReturnNull_WhenFileHasNoCoverArt()
        {
            
            string filePath = "test.m4a";
            File file = File.Create(filePath);

            Image image = MediaScanner.getCoverArt(file);

            Assert.IsNotNull(image);

        }



    }
}
