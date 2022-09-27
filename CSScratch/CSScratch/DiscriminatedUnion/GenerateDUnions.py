# GenerateDUntions.py
#
# Generates C# code for DUnions.
#

def generateTypeParameterList(n):
    return ", ".join(f"T{x}" for x in range(1, n + 1))

def generateConstructors(n):
    source = ""
    source += "        #region CTORS\n"
    for n in range(1, n+1):
        source += f"        public DUnion(T{n} t{n}) : base(new DUnionValue<T{n}>(t{n})) {{ }}\n"
    source += "        #endregion\n"

    return source

def generateIsMethods(n):
    source = ""
    source += "        #region IsMethods\n"
    for n in range(1, n+1):
        source += f"        public bool Is(DUnionType<T{n}> t{n}) => UnionValue.IsType<T{n}>();\n"
    source += "        #endregion\n"

    return source

def generateGetMethods(n):
    source = ""
    source += "        #region GetMethods\n"
    for n in range(1, n+1):
        source += f"        public T{n} Get(DUnionType<T{n}> k) => UnionValue.Get<T{n}>();\n"
    source += "        #endregion\n"

    return source

def generateSwitchP(n):
    actionList = ", ".join(f"Action<T{i}> t{i}Action" for i in range(1, n+1))
    source = ""
    source += f"        public void SwitchP({actionList})\n"
    source += "        {\n"
    for i in range(1, n+1):
        stType = "if" if i == 1 else "else if"
        source += f"            {stType} (Is(DUnionType.Of<T{i}>()))\n"
        source += f"                t{i}Action(Get(DUnionType.Of<T{i}>()));\n"

    source += f"            else\n"
    source += "                throw new InvalidOperationException(\"This should not be possible.\");\n"
    source += "        }\n"

    return source

def generateSwitch(n):
    funcList = ", ".join(f"Func<T{i}, T> t{i}Func" for i in range(1, n+1))
    source = ""
    source += f"        public T Switch<T>({funcList})\n"
    source += "        {\n"
    for i in range(1, n+1):
        stType = "if" if i == 1 else "else if"
        source += f"            {stType} (Is(DUnionType.Of<T{i}>()))\n"
        source += f"                return t{i}Func(Get(DUnionType.Of<T{i}>()));\n"

    source += f"            else\n"
    source += "                throw new InvalidOperationException(\"This should not be possible.\");\n"
    source += "        }\n"

    return source

def generateMainClass(n):
    typeParameterList = generateTypeParameterList(n)

    source = ""
    source += f"    public class DUnion<{typeParameterList}> : DUnion\n"
    source += "    {\n"

    source += "\n"
    source += generateConstructors(n)
    
    source += "\n"
    source += generateIsMethods(n)
    
    source += "\n"
    source += generateGetMethods(n)
    
    source += "\n"
    source += generateSwitchP(n)
    
    source += "\n"
    source += generateSwitch(n)

    source += "    }\n"
    return source

def generateSource(maxN):
    source = ""
    source += "namespace CSScratch.DiscriminatedUnion\n"
    source += "{\n"

    for n in range(1, maxN+1):
        source += "\n"
        source += generateMainClass(n)
    
    source += "}\n"
    return source

print(generateSource(16))
