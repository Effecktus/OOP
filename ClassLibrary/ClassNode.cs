namespace ClassLibrary
{
    public class ClassNode
    {
        public ClassNode(ClassFigure data) 
        {
            Data = data;
        }
        public ClassFigure Data { get; set; }
        public ClassNode Next { get; set; }
    }
}
