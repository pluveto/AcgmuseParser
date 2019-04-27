using AcgmuseParser.Model;
using Melanchall.DryWetMidi.Smf;
using Melanchall.DryWetMidi.Smf.Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgmuseParser.Util
{
    class MidiConverter
    {
        internal static string ToJe(string fileName, int threshold1, int threshold2, int threshold3, int octBias = 0, bool spl = true)
        {
            MidiFile midiFile = null;

            try
            {
                midiFile = MidiFile.Read(fileName);
            }
            catch (Exception)
            {
                return "转换失败，文件是坏的。";
            }
            var sb = new StringBuilder();
            
            foreach (var trackChunk in midiFile.Chunks.OfType<TrackChunk>())
            {
                sb.Append("\r\n---------Track: " + trackChunk.ChunkId + "-----------\r\n");
                var manage = trackChunk.ManageNotes();
                var list = manage.Notes.ToList();

                list = _listBias(manage.Notes, octBias);


                for (int i = 0; i < list.Count; i++)
                {
                    var x = list[i];
                    long deltaTime = 0;
                    try
                    {
                        sb.Append(NoteTable.Dict[x.NoteNumber]/* + ":" + deltaTime*/ +( spl?" ":""));
                    }
                    catch (System.Collections.Generic.KeyNotFoundException)
                    {
                        return "转换失败，八度超过有效范围。";
                    }
                    
                    if (i < list.Count - 1)
                    {
                        var next = list[i + 1];
                        deltaTime = Math.Abs(x.Time - next.Time);
                        if (deltaTime > threshold3)
                            sb.Append("\r\n\r\n");
                        else if (deltaTime > threshold2)
                            sb.Append("\r\n");
                        else if (deltaTime > threshold1)
                            sb.Append("    ");
                    }

                }
            }
            return sb.ToString();
        }

        private static List<Note> _listBias(NotesCollection notes, int octBias = 0)
        {

            if (octBias == 0) return notes.ToList();
            var list = notes.ToList();
            foreach (var item in list)
            {
                item.SetNoteNameAndOctave(item.NoteName,item.Octave + octBias);
            }
            return list;
        }
    }
}
