using System;

class Converter<TInput, TOutput> {
    private Func<TInput, TOutput> _converter;

    public Converter(Func<TInput, TOutput> converter) {
        _converter = converter;
    }

    public TOutput Convert(TInput target) {
        return _converter(target);
    }

    public TOutput[] ConvertAll(TInput[] arr) {
        TOutput[] result = new TOutput[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            result[i] = _converter(arr[i]);
        }

        return result;
    }
}