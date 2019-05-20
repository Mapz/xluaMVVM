ResManager = CS.Mapz.Core.Component.ResManager

function table.is_empty(t)
    return _G.next(t) == nil
end

-- _n nil 全打
function table.tostring(t, _n)
    -- if AppConfig.is_format_log == true then
    -- 	return "";
    -- end
    if t == nil then
        return "nil"
    end
    if type(t) ~= "table" then
        return ""
    end
    local _t = {}
    --_n = _n or 0
    function _t:_tostring(t, n)
        if _n and n > _n then
            return ""
        end

        self[t] = n
        local str = {}
        local fmt = {}
        n = n or 0
        for i = 1, n do
            fmt[#fmt + 1] = "  "
        end
        local fmt_str = table.concat(fmt)

        str[#str + 1] = "{\n"
        if type(t) ~= "table" then
            print("打印表传入的不是表。。" .. debug.traceback())
        end
        for k, v in pairs(t) do
            if type(v) == "table" and not self[v] then
                if type(k) == "number" then
                    key = "[" .. tostring(k) .. "]"
                else
                    key = tostring(k)
                end
                str[#str + 1] = string.format("  %s%s=", fmt_str, key)
                str[#str + 1] = self:_tostring(v, n + 1)
            elseif type(v) == "string" then
                local key
                if type(k) == "number" then
                    key = "[" .. tostring(k) .. "]"
                else
                    key = tostring(k)
                end
                str[#str + 1] = string.format("  %s%s='%s',\n", fmt_str, key, tostring(v))
            else
                local key
                if type(k) == "number" then
                    key = "[" .. tostring(k) .. "]"
                else
                    key = tostring(k)
                end
                str[#str + 1] = string.format("  %s%s=%s,\n", fmt_str, key, tostring(v))
            end
        end

        str[#str + 1] = fmt_str .. "},\n"
        return table.concat(str)
    end
    return _t:_tostring(t, 0)
end
